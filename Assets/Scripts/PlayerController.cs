using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int R = 255;
    public int G = 255;
    public int B = 255;
    public GameObject potatoPrefab;
    [HideInInspector]
    public int actualInventory = 0;
    private Rigidbody _rigidBody;
    private float _dropOffsetHorizontal = 1f;
    private float _dropOffsetVertical = 4f;
    private float _minDropForce = 40f;
    private float _dropForce = 50f;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public FoodModel DownloadFood()
    {
        FoodModel food = new FoodModel(R, G, B, actualInventory);
        // actualInventory = 0;
        return food;
    }

    public void DropPotatoes()
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
