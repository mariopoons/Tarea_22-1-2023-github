using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    public string username;
    public string password;

    private void Start()
    {
        Login(username, password);
    }

    public bool Login(string username, string password)
    {
        if (username == "Mario" && password=="1234")
        {
            Debug.Log($"Correct login");
            return true;
        }
        else
        {
            Debug.Log($"Wrong login");
            return false;
        }
    }
}
