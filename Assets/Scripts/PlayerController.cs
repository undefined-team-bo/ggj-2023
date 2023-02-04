using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int R = 255;
    public int G = 255;
    public int B = 255;
    public int actualInventory = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public FoodModel DownloadFood()
    {
        FoodModel food = new FoodModel(R,G,B,actualInventory);
        // actualInventory = 0;
        return food;
    }
}
