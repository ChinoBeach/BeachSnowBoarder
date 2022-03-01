using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    //member variables
    [SerializeField] float fltDelayTime = .5f;
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the player crosses the finish line

        if(other.tag == "Player")
        {
            Invoke("ReloadScene", fltDelayTime);
        }
        
    }
    void ReloadScene()
    {
        //restart the game
        SceneManager.LoadScene(0);
    }
}
