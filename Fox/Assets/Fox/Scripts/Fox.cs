using UnityEngine;
using System.Collections;

public class Fox : MonoBehaviour {
    public Animator fox;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            fox.SetBool("idle", true);
            fox.SetBool("walk", false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            fox.SetBool("walk", true);
            fox.SetBool("idle", false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            fox.SetBool("walk", false);
            fox.SetBool("run", true);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            fox.SetBool("run", false);
            fox.SetBool("attack1", true);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            fox.SetBool("attack1", false);
            fox.SetBool("attack2", true);
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            fox.SetBool("attack2", false);
            fox.SetBool("bite", true);
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            fox.SetBool("bite", false);
            fox.SetBool("growl", true);
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            fox.SetBool("growl", false);
            fox.SetBool("jump", true);
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            fox.SetBool("jump", false);
            fox.SetBool("sneak", true);
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            fox.SetBool("sneak", false);
            fox.SetBool("eat", true);
        }
        if (Input.GetKey(KeyCode.Keypad0))
        {
            fox.SetBool("eat", false);
            fox.SetBool("hit", true);
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            fox.SetBool("hit", false);
            fox.SetBool("die", true);
        }
    }
}
