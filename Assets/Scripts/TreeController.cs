using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence;
using Coherence.Toolkit;
using TMPro;

public class TreeController : MonoBehaviour
{
    [OnValueSynced(nameof(UpdateHealthR))]
    public float HealthR = 255;
    [OnValueSynced(nameof(UpdateHealthG))]
    public float HealthG = 255;
    [OnValueSynced(nameof(UpdateHealthB))]
    public float HealthB = 255;
    public float multiplierR = 0.07f;
    public float multiplierG = 0.07f;
    public float multiplierB = 0.07f;
    public int velocityReduceLifeR = 10;
    public int velocityReduceLifeG = 10;
    public int velocityReduceLifeB = 10;
    public bool IsConnected = false;
    public TextMeshProUGUI textField;

    public SpriteRenderer spriteRendererTree1;
    public SpriteRenderer spriteRendererTree2;
    private CoherenceSync _coherenceSync;
    private CoherenceMonoBridge _monoBridge;

    public Vector3 lastColor;
    public int lastQuantity;

    private float updateLightMax = 3f;
    private float updateLightTime = 0f;
    private void Awake()
    {
        _monoBridge = FindObjectOfType<CoherenceMonoBridge>();
        _monoBridge.onLiveQuerySynced.AddListener(MonoBridgeOnOnLiveQuerySynced);
    }

    private void MonoBridgeOnOnLiveQuerySynced(CoherenceMonoBridge obj)
    {
        _coherenceSync = this.gameObject.GetComponent<CoherenceSync>();
    }

    public void UpdateHealthR(float oldHealth, float newHealth)
    {
        HealthR = newHealth;
        Debug.Log($" R changed by: {newHealth} - {oldHealth}");
    }
    public void UpdateHealthG(float oldHealth, float newHealth)
    {
        HealthG = newHealth;
        Debug.Log($" G changed by: {newHealth} - {oldHealth}");
    }
    public void UpdateHealthB(float oldHealth, float newHealth)
    {
        HealthB = newHealth;
        Debug.Log($" B changed by: {newHealth} - {oldHealth}");
    }

    void FixedUpdate()
    {

        textField.text = $"{(int)HealthR},{(int)HealthG},{(int)HealthB}";
        spriteRendererTree1.color = new Color32((byte)HealthR, (byte)HealthG, (byte)HealthB, 255);
        spriteRendererTree2.color = new Color32((byte)HealthR, (byte)HealthG, (byte)HealthB, 255);
        GameObject player = GameObject.FindWithTag("Player");
        IsConnected = player != null;
        if (IsConnected)
        {
            updateLightTime  += Time.deltaTime;
            if (updateLightTime > updateLightMax)
            {
                updateLightTime = 0;
                SunLightChange();
            }
            if (_coherenceSync == null)
            {
                _coherenceSync = this.gameObject.GetComponent<CoherenceSync>();
            }
            // if (_coherenceSync.HasStateAuthority)
            // {
            HealthR = HealthR - Time.deltaTime * velocityReduceLifeR;
            if (HealthR < 0)
                HealthR = 0;
            HealthG = HealthG - Time.deltaTime * velocityReduceLifeG;
            if (HealthG < 0)
                HealthG = 0;
            HealthB = HealthB - Time.deltaTime * velocityReduceLifeB;
            if (HealthB < 0)
                HealthB = 0;
            // }
        }
    }
    public void SunLightChange()
    {
        LightController.instance.SwitchColor(new Color32((byte)HealthR, (byte)HealthG, (byte)HealthB, 255));
    }

    public void RestoreHealth(Vector3 amount, int quantity)
    {
        lastColor = amount;
        lastQuantity = quantity;
        _coherenceSync = this.gameObject.GetComponent<CoherenceSync>();
        if (_coherenceSync.HasStateAuthority)
        {
            HealthR = HealthR + amount.x * quantity * multiplierR;
            HealthG = HealthG + amount.y * quantity * multiplierG;
            HealthB = HealthB + amount.z * quantity * multiplierB;
            if (HealthR > 255)
                HealthR = 255;
            if (HealthG > 255)
                HealthG = 255;
            if (HealthB > 255)
                HealthB = 255;
            // SunLightChange();
        }
        else
        {
            _coherenceSync.SendCommand<TreeController>(nameof(RestoreHealthNet), MessageTarget.AuthorityOnly);
        }

    }
    public void RestoreHealthNet()
    {

        HealthR = HealthR + lastColor.x * lastQuantity * multiplierR;
        HealthG = HealthG + lastColor.y * lastQuantity * multiplierG;
        HealthB = HealthB + lastColor.z * lastQuantity * multiplierB;
        if (HealthR > 255)
            HealthR = 255;
        if (HealthG > 255)
            HealthG = 255;
        if (HealthB > 255)
            HealthB = 255;
        // SunLightChange();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FoodModel food = other.gameObject.GetComponent<PlayerController>().DownloadFood();
            Vector3 color = new Vector3(food.R, food.G, food.B);
            Debug.Log($"Food: {food.R},{food.G},{food.B}");
            RestoreHealth(color, food.Quantity);
        }
    }
}
