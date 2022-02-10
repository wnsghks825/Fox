using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    const float vecSpeed = 10f;
    Vector3 mPrevPos = Vector3.zero;
    Vector3 mPosDelta = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {

    }

    //// Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.tag == "Fox")
                {
                    //mPosDelta = Input.mousePosition - mPrevPos;

                    //mPrevPos = Input.mousePosition;
                    mPosDelta = Input.mousePosition - mPrevPos;


                    transform.Rotate(transform.up, -Vector3.Dot(mPosDelta, Camera.main.transform.right), Space.World);

                    //transform.Rotate(transform.right, -Vector3.Dot(mPosDelta, Camera.main.transform.up), Space.World);

                    mPrevPos = Input.mousePosition;
                }
            }

        }
    }
}
