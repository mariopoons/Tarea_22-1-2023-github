using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise4 : MonoBehaviour
{
    public int[] myArray = new int[5];

    private void Start()
    {
        Debug.Log("First element: " + myArray[0]);
        Debug.Log("Third element: " + myArray[2]);
        Debug.Log("Fifth element: " + myArray[4]);
    }
}
