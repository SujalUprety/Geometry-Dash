using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Winning : MonoBehaviour
{
   
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        gameManager.GameComplete();
    }
}
