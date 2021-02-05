using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attempt : MonoBehaviour
{
    
    public GameObject attempt_done;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        attempt_done.SetActive(false);
    }

}
