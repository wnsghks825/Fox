using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WayRotate : MonoBehaviour, IDragHandler
{
    const float const_fRot_Dist = 0.5f;
    const float vecSpeed = 7f;
    public GameObject myObj;

    public enum Swipe
    {
        None,
        Up,
        Down,
        Left,
        Right,
        UpLeft,
        UpRight,
        DownLeft,
        DownRight
    };

    public static Swipe swipeDirection;
    public void OnDrag(PointerEventData eventData)
    {
        if (null == myObj)
            Debug.Log("게임오브젝트가 없다.");

        float fRotX = eventData.delta.x * Mathf.Deg2Rad;
        float fRotY = eventData.delta.y * Mathf.Deg2Rad;

        Vector3 vecUp = Vector3.right * fRotY * vecSpeed;
        Vector3 vecRight = Vector3.down * fRotX * vecSpeed;
        Vector3 vecRot = vecRight + vecUp;
        myObj.transform.Rotate(vecRot, Space.World);
    }

}
