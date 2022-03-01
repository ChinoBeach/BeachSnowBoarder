using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the player crosses the finish line

        if(other.tag == "Player")
        {
            Debug.Log("You Finished!");
        }
        
    }
}
