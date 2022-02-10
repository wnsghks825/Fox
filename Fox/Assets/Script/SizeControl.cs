using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SizeControl : MonoBehaviour
{

    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;
    private Ray ray;
    private RaycastHit hit;
    private float initialFingersDistance;
    private Vector3 initialScale;
    private Vector3 limit;
    public float minValue;
    public float maxValue;
    public GameObject objectTemp;
    private Vector3 _rotation;
    private float _sensitivity = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        _rotation = Vector3.zero;


    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButton(0))
        //{
        //    ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        //    {
        //        if (hit.transform.tag == "Fox")
        //        {
        //            //mPosDelta = Input.mousePosition - mPrevPos;

        //            //mPrevPos = Input.mousePosition;
        //            mPosDelta = Input.mousePosition - mPrevPos;


        //            transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);

        //            //transform.Rotate(transform.right, -Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);



        //            mPrevPos = Input.mousePosition;
        //        }
        //    }

        //}

        if (Input.touches.Length == 2)
        {
            CheckTouch();
            return;
        }

    }
    void CheckTouch()
    {
        if (Input.touches.Length == 2)
        {
            Touch t1 = Input.touches[0];
            Touch t2 = Input.touches[1];

            if (t1.phase == TouchPhase.Began || t2.phase == TouchPhase.Began)
            {
                initialFingersDistance = Vector2.Distance(t1.position, t2.position);
                initialScale = objectTemp.transform.localScale;
            }
            else if (t1.phase == TouchPhase.Moved || t2.phase == TouchPhase.Moved)
            {
                float currentFingersDistance = Vector2.Distance(t1.position, t2.position);
                var scaleFactor = currentFingersDistance / initialFingersDistance;

                Vector3 m_scale = initialScale * scaleFactor;
                m_scale.x = Mathf.Clamp(m_scale.x, minValue, maxValue);
                m_scale.y = Mathf.Clamp(m_scale.y, minValue, maxValue);
                m_scale.z = Mathf.Clamp(m_scale.z, minValue, maxValue);
                //기본값에 최대최소 곱하기.
                objectTemp.transform.localScale = m_scale;
            }
        }
    }
}
