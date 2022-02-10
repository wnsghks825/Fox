using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    int y;
    public GameObject ExitPanel;
    private void Start()
    {
        
    }
    public void Exit()
    {
        ExitPanel.SetActive(true);
        Time.timeScale = 0;
    }
    public void Cancel()
    {
        ExitPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void Confirm()
    {
        Application.Quit();
    }
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void Back()
    {
        y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(y - 1);
    }

    public void Back2()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void nextScene()
    {
        ScoreManager.Instance.nextCheck++;
        y = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(y + 1);

    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void ChangeScene(int sc)
    {
        ScoreManager.Instance.nextCheck++;
        SceneManager.LoadSceneAsync(sc);
    }
}
