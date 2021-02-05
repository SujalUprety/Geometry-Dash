using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Congratulations : MonoBehaviour
{

    public Text congratulations;

    // Update is called once per frame
    void Update()
    {
        int cong_s = Attempts.attempts;
        congratulations.text = cong_s.ToString();
        //Debug.Log(cong_s);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
