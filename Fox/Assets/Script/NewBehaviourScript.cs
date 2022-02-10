using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void PanelChange()
    {
        Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
