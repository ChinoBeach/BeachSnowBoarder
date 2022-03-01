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
    void OnTriggerEnter2D(Collider2D other)
    {
        //If you bump your head
        if(other.tag == "Ground")
        {
            //if you hit your head(lose), restart the game
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
