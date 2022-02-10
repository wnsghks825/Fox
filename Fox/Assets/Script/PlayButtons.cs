using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButtons : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Fox;
    public GameObject TransparentFox;
    
    public GameObject TransparentPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PressButton()
    {
        Panel1.SetActive(false);
        TransparentPanel.SetActive(false);
        Fox.SetActive(true);
        TransparentFox.SetActive(true);
    }
}
