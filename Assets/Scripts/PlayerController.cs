using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using Coherence;
using Coherence.Toolkit;
using Coherence.UI;
public class PlayerController : MonoBehaviour
{
    public TextMeshProUGUI inventoryText;
    public TextMeshProUGUI playerName;

    public SpriteRenderer spriteRenderer;
    public Light myLight;

    public TrailRenderer trail;

    public GameObject joinMessage;
    public string playerNameString;
    public int R = 255;
    public int G = 255;
    public int B = 255;
    public GameObject potatoPrefab;
    public int actualInventory = 0;
    private Rigidbody _rigidBody;
    private float _dropOffsetHorizontal = 1f;
    private float _dropOffsetVertical = 4f;
    private float _minDropForce = 40f;
    private float _dropForce = 50f;

    private CoherenceSync _coherenceSync;
    private CoherenceMonoBridge _monoBridge;
    private void Awake()
    {
        _monoBridge = FindObjectOfType<CoherenceMonoBridge>();
        _monoBridge.onLiveQuerySynced.AddListener(MonoBridgeOnOnLiveQuerySynced);
    }
    private void MonoBridgeOnOnLiveQuerySynced(CoherenceMonoBridge obj)
    {
        _coherenceSync = this.gameObject.GetComponent<CoherenceSync>();
    }
    void Start()
    {

        playerNameString = WorldsConnectDialog.PlayerName;
        _rigidBody = GetComponent<Rigidbody>();
        GameObject message =  Instantiate(joinMessage);
        SetInitialColor();
    }

    private void SetInitialColor()
    {
        Color32 color = ColorManager.instance.GetColorRandom();
        R = color.r;
        G = color.g;
        B = color.b;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        inventoryText.text = $"{actualInventory}";
        playerName.text = $"{playerNameString}";
        Color32 startColor = new Color32((byte)R, (byte)G, (byte)B, 255);
        spriteRenderer.color = startColor;
        myLight.color = startColor;
        trail.startColor = new Color32(startColor.r, startColor.g, startColor.b, 150);
    }

    public FoodModel DownloadFood()
    {
        FoodModel food = new FoodModel(R, G, B, actualInventory);
        actualInventory = 0;
        return food;
    }

    public void DropPotatoes()
    {
        _coherenceSync = this.gameObject.GetComponent<CoherenceSync>();
        if (_coherenceSync.HasStateAuthority)
        {
            DropPotatoesNet();
        }
        else
        {
            _coherenceSync.SendCommand<PlayerController>(nameof(PlayerController.DropPotatoesNet), MessageTarget.AuthorityOnly);
        }

    }
    public void DropPotatoesNet()
    {
        if (actualInventory > 0)
        {
            StartCoroutine(DropPotatoesCR(actualInventory));
            actualInventory = 0;
        }
    }

    IEnumerator DropPotatoesCR(int numOfPotatoes)
    {
        while (numOfPotatoes > 0)
        {
            Vector2 randomPos = Random.insideUnitCircle * _dropOffsetHorizontal;
            Vector3 potatoPos = new Vector3(transform.position.x + randomPos.x, transform.position.y + _dropOffsetVertical, transform.position.z + randomPos.y);
            GameObject potato = Instantiate(potatoPrefab, potatoPos, Quaternion.identity, PotatoSpawnerController.instance.transform);

            Rigidbody potatoRB = potato.GetComponent<Rigidbody>();
            Vector2 randomForce = Random.insideUnitCircle * _dropForce;
            potatoRB.AddForce(new Vector3(_minDropForce + randomForce.x, _minDropForce, _minDropForce + randomForce.y));
            numOfPotatoes--;
            yield return new WaitForFixedUpdate();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Potato"))
        {
            actualInventory += 1;
            Destroy(collider.transform.parent.gameObject);
        }
    }
}
