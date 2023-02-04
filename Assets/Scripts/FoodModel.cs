using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class FoodModel
{
    public int R;
    public int G;
    public int B;
    public int Quantity;
    public FoodModel(int r, int g, int b, int quantity)
    {
        R = r;
        G = g;
        B = b;
        Quantity = quantity;
    }
}
