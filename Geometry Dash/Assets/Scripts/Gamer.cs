using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamer : MonoBehaviour
{

    public static bool camera_move;

    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        camera_move = true;
        /* Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; */
    }

    // Update is called once per frame
    void Update()
    {
        if(camera_move == true)
        {   
            float Xaxis = speed * Time.deltaTime;
            Vector3 move = new Vector3(Xaxis, 0f, 0f);

            gameObject.transform.Translate(move);
        }
    }
}
