using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float restartDelay = 1f;

    public GameObject gameComleted;
    public GameObject Player;

    public void GameComplete()
    {
        gameComleted.SetActive(true);
    }

    public void GameRestart()
    {
        Destroy(Player);
        Gamer.camera_move = false;
        Invoke("Restart",restartDelay);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Attempts.attempts++;
    }

}
