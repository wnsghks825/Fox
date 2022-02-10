using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public GameObject ExitPanel;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Exit()
    {
        ExitPanel.SetActive(true);
    }
    public void GameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void Cancel()
    {
        ExitPanel.SetActive(false);
    }
    public void Confirm()
    {
        Application.Quit();
    }

}
