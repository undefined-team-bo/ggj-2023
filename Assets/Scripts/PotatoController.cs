using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotatoController : MonoBehaviour
{
    private float _ttl = 10f;
    private float _currentTTL = 0f;
    void Update()
    {
        if (_currentTTL < _ttl)
        {
            _currentTTL += Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }

    }
}
