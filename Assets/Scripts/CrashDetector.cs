using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        //If you bump your head
        if(other.tag == "Ground")
        {
            //if you hit your head(lose), restart the game
            SceneManager.LoadScene(0);
        }
    }
}
