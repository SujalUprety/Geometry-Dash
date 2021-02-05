using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpforce = 400f;


    public Rigidbody2D rb;

    public bool isgrounded = true;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
        //SoundManager.play = false;
    }

    void Update() 
    {
        Jump();
    }

   void Jump()
   {
       if(Input.touchCount > 0 && isgrounded == true)
       {
           rb.AddForce(new Vector2(0f, jumpforce));
           transform.Rotate(0f, 0f, -90f);
           isgrounded = false;
       }
   }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("Ground") && isgrounded == false)
        {
             isgrounded = true;
        }
     }
     

}
