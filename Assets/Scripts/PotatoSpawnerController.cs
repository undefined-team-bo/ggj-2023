using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class PotatoSpawnerController : MonoBehaviour
{
    public GameObject prefabToSpawn;
    private float _spawnRange = 10f;
    private float _spawnCD = 2f;
    private float _minSpawnCD = 0.5f;
    private float _currentSpawnCD = 0f;

    void Update()
    {
        if (_currentSpawnCD > 0)
        {
            _currentSpawnCD -= Time.deltaTime;
        }
        else
        {
            _currentSpawnCD = _minSpawnCD + _spawnCD * Random.value;
            SpawnPotato();
        }

    }

    private void SpawnPotato()
    {
        Vector3 randomPos = new Vector3(GetRandomInRange(), transform.position.y, GetRandomInRange());
        GameObject potato = Instantiate(prefabToSpawn, randomPos, Quaternion.identity, transform);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawCube(transform.position, Vector3.one * _spawnRange);
    }

    private float GetRandomInRange()
    {
        return Random.Range(-_spawnRange, _spawnRange);
    }
}
