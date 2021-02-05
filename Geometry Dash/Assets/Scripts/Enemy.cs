using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   
    public AudioSource deathsfx;

    public GameManager gameManager;

    void Start() 
    {
        deathsfx = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        gameManager.GameRestart();
        //Attempts.attempts++;
        //SoundManager.play = true;
        deathsfx.Play();
    }

}
