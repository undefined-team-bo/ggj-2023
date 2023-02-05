using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageLifeTime : MonoBehaviour
{
    public float maxTimeLife = 3f;
    private float timeLife = 0f;
    void FixedUpdate()
    {
        timeLife += Time.deltaTime;
        if (timeLife >= maxTimeLife)
        {
            Destroy(this.gameObject);
        }
    }
}
