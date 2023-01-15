using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    private int counter = 1;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log($"You pressed {counter} times A");
            AddCounter();
        }
    }

   void AddCounter()
    {
        counter++;
            if (counter >= 11)
        {
            Debug.Log("Game Over");
        }
    }
}
