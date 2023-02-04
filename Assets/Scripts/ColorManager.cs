using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{

    public static ColorManager instance { get; private set; }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    public Color32[] colors;

    public Color32 GetColor(int index)
    {
        return colors[index];
    }

    public Color32 GetColorRandom()
    {
        return colors[Random.Range(0, colors.Length)];
    }
}
