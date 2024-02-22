using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject RetryPanel;


    private void Awake()
    {
        instance = this;
    }





    public void retryButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void startButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void introButton()
    {
        SceneManager.LoadScene("IntroScene");
    }
    public void GameOver()
    {
        RetryPanel.SetActive(true);
        Time.timeScale = 0.0f;
    }



}
