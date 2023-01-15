using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    
    public int[] myArray = new int[5];

    void Start()
    {
        if (myArray.Length >= 5)
        {
            Debug.Log("First element: " + myArray[0]);
            Debug.Log("Third element: " + myArray[2]);
            Debug.Log("Fifth element: " + myArray[4]);
        }
        else
        {
            Debug.Log("Missing elements");
        }
    }
}

