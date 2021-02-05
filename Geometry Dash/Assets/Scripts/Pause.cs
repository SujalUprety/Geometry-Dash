using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject pausePanel;
    public GameObject congratulations;

    private void Start() 
    {
        pausePanel.SetActive(false);
    }

    private void Update() 
    {
        
        if(Input.GetButtonDown("Cancel"))
        {
            if (!pausePanel.activeInHierarchy && !congratulations.activeInHierarchy) 
            {
                PauseGame();
            }
            else if (pausePanel.activeInHierarchy) 
            {
                 Continue();   
            }
            //Debug.Log("Is pressed");
        }

    }

    public void Continue()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        /*Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;*/
    }    

    public void MenuPaused()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
    }

    public void PauseGame()
    {
        /*Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;*/
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

}
