using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;
using Coherence.Toolkit;
using Coherence;
public class PotatoSpawnerController : MonoBehaviour
{
    public static PotatoSpawnerController instance { get; private set; }
    public GameObject prefabToSpawn;
    private float _spawnRange = 10f;
    private float _spawnCD = 2f;
    private float _minSpawnCD = 0.5f;
    private float _currentSpawnCD = 0f;
    private CoherenceSync _coherenceSync;
    private CoherenceMonoBridge _monoBridge;


    private void Awake()
    {
        _monoBridge = FindObjectOfType<CoherenceMonoBridge>();
        _monoBridge.onLiveQuerySynced.AddListener(MonoBridgeOnOnLiveQuerySynced);
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    private void MonoBridgeOnOnLiveQuerySynced(CoherenceMonoBridge obj)
    {
        _coherenceSync = this.gameObject.GetComponent<CoherenceSync>();
    }

    void Update()
    {
        if (_currentSpawnCD > 0)
        {
            _currentSpawnCD -= Time.deltaTime;
        }
        else
        {
            _currentSpawnCD = _minSpawnCD + _spawnCD * Random.value;
            if (_coherenceSync.HasStateAuthority)
            {
                SpawnPotato();
            }
            else
            {
                _coherenceSync.SendCommand<PotatoSpawnerController>(nameof(PotatoSpawnerController.SpawnPotato), MessageTarget.AuthorityOnly);
            }

        }

    }

    public void SpawnPotato()
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
