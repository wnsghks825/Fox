using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PreviewObject : MonoBehaviour, IDragHandler
{

    public GameObject myObj;
    const float vecSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        myObj.transform.rotation = Quaternion.Euler(new Vector3(0, 210, 0));
    }
    //현재 eventDelta의 값을 가지고 있으므로 여우가 나왔을 때의 각도가 각각 다르다. 
    public void OnDrag(PointerEventData eventData)
    {
        float fRotX = eventData.delta.x * Mathf.Deg2Rad;
        float fRotY = eventData.delta.y * Mathf.Deg2Rad;

        Vector3 vecRight = Vector3.down * fRotX * vecSpeed;
        myObj.transform.Rotate(vecRight, Space.Self);
    }


}
