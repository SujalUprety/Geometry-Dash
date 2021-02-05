using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attempts : MonoBehaviour
{
    
    public static int attempts = 1;
    public Text attempted;


    private void Start() 
    {
        attempted = GetComponent<Text>();
    }

    // Update is called once per frame
    private void Update()
    {
        attempted.text = attempts.ToString();
    }

    public void Text() 
    {
        attempts++;
    }
    
}
