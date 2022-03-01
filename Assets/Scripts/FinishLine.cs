using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the player crosses the finish line

        if(other.tag == "Player")
        {
            //if you win, restart the game
            SceneManager.LoadScene(0);
        }
        
    }
}
