using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    //memeber variables
    [SerializeField] float fltLoadDelay = .5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        //If you bump your head
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            //if you hit your head(lose), restart the game, also make it so that you cant move anymore
            FindObjectOfType<PlayerController>().DisableControl();

            crashEffect.Play();
               
            
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", fltLoadDelay);
        }
    }

    void ReloadScene()
    {
        //restart the game
        SceneManager.LoadScene(0);
    }
}
