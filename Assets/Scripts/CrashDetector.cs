using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        //If yoy bump your head
        if(other.tag == "Ground")
        {
            Debug.Log("You bumped your head");
        }
    }
}
