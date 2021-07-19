using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBasics : MonoBehaviour
{
    /// <summary>
    /// VARIABLES
    /// int - integers
    /// double - decimals (4.0)
    /// float - decimals (4.0f)
    /// string - sentences, words
    /// char - single character
    /// bool - true/false
    /// </summary>


    // Start is called before the first frame update
    void Start()
    {
        //if ()
        //{

        //}
        //else if ()
        //{

        //}
        //else
        //{

        //}

        //for (int i; i < 10; i++)
        //{

        //}

        //bool isTrue = true;
        //while (isTrue)
        //{
        //    // A lot of coding goes here
        //    isTrue = false;
        //}

        //int[] integers = { 1, 2, 3, 4, 5, 6, 7 };
        //foreach (int k in integers)
        //{
        //    // Loops through the whole integers array
            
        //}
        Debug.Log("Hello");
        int intIndex = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
    }

    void checkMovement()
    {
        // movement checking goes here
    }
}
