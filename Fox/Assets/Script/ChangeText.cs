using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeText : MonoBehaviour
{
    public GameObject[] Text;
    private int y;
    public GameObject Background;

    
    public void NextPanel()
    {

        Text[0].SetActive(false);
        Text[1].SetActive(true);
    }
    public void Back()
    {
        SceneManager.LoadSceneAsync(0);
    }
    private void Update()
    {
        if (ScoreManager.Instance.nextCheck>0 && SceneManager.GetActiveScene().name== "Description")
        {
            GetComponentsInChildren<AudioSource>()[0].Stop();
        }
        if (ScoreManager.Instance.nextCheck > 1 && SceneManager.GetActiveScene().name == "Select")
        {
            GetComponentsInChildren<AudioSource>()[0].Stop();
        }
    }
}
