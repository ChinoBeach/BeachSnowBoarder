using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    //member variables
    [SerializeField] float fltDelayTime = .5f;
    [SerializeField] ParticleSystem finishEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        //if the player crosses the finish line

        if(other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", fltDelayTime);
            
        }
        
    }
    void ReloadScene()
    {
        //restart the game
        SceneManager.LoadScene(0);
    }
}
