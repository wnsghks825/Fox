using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{
    public GameObject dropPosition;
    public GameObject background;
    public GameObject Fox;
    public GameObject Text;
    private Ray ray;
    private RaycastHit hit;
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;
    public void Start()
    {
        Fox.SetActive(false);
    }

    void OnMouseDrag()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 9.0f;
        transform.position = mousePos;
    }

    void OnMouseUp()
    {
        float distance = Vector2.Distance(this.transform.position, dropPosition.transform.position);

        print(distance);
        print("distance : " + distance);

        if (distance < 2f)
        {
            this.transform.position = dropPosition.transform.position;
            dropPosition.SetActive(false);
            Fox.SetActive(true);
            Text.SetActive(true); 
            background.SetActive(true);
            gameObject.SetActive(false);
        }
    }


}
