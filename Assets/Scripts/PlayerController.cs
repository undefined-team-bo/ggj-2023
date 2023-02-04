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
    private float dropOffsetHorizontal = 1f;
    private float dropOffsetVertical = 3f;

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

    public void DropPotatos()
    {
        if (actualInventory > 0)
        {
            StartCoroutine(DropPotatosCR(actualInventory));
            actualInventory = 0;
        }
    }

    IEnumerator DropPotatosCR(int numOfPotatos)
    {
        while (numOfPotatos > 0)
        {

            Vector2 randomCircle = Random.insideUnitCircle * dropOffsetHorizontal;
            Vector3 randomPos = new Vector3(transform.position.x + randomCircle.x, transform.position.y + dropOffsetVertical, transform.position.z + randomCircle.y);
            GameObject potato = Instantiate(potatoPrefab, randomPos, Quaternion.identity, PotatoSpawnerController.instance.transform);
            Rigidbody potatoRB = potato.GetComponent<Rigidbody>();
            potatoRB.AddForce(Vector3.up * 50f);
            numOfPotatos--;
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
