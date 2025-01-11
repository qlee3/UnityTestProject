using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{

    int thisYear = 2000;
    string myName;

    float myFloat = 3.14f;

    int hp = 90;

    // Start is called before the first frame update
    void Start()
    {
        hp = hp - 100;

        if (hp <= 0)
        {
            Debug.Log("Player is dead");
        }
        else
        {
            Debug.Log("Player is alive");
        }
    }

    // Update is called once per frame
    void Update()
    {
        myFloat = myFloat + 0.01f;
        Debug.Log("Hello World");
        Debug.Log("Hello World" + myFloat);
    }
}
