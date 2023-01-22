using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public float x;
    public float y;
    public float z;

    void Start()
    {
        float arithmeticMean = CalculateMean(x, y, z);
        Debug.Log("The mean of the values is " + arithmeticMean);
    }

    float CalculateMean(float x, float y, float z)
    {
        return (x + y + z) / 3;
    }
}
