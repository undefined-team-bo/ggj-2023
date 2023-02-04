using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Coherence;
using Coherence.Toolkit;
using TMPro;

public class TreeController : MonoBehaviour
{
    [OnValueSynced(nameof(UpdateHealthLabel))]
    public float Health = 100;
    public bool IsConnected = false;
    public TextMeshProUGUI textField;

    public void UpdateHealthLabel(float oldHealth, float newHealth)
    {
        Health = newHealth;
        Debug.Log($" HP changed by: {newHealth} - {oldHealth}");
    }

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        IsConnected = player != null;
        if (IsConnected)
        {
            Health = Health - Time.deltaTime * 10;
            textField.text = $"{Health}";
        }
    }
}
