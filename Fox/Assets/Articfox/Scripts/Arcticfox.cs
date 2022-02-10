using UnityEngine;
using System.Collections;

public class Arcticfox : MonoBehaviour {
    Animator arcticfox;
    private IEnumerator Coroutine;
	// Use this for initialization
	void Start () {
        arcticfox = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            arcticfox.SetBool("idle", true);
            arcticfox.SetBool("hunt", false);
            arcticfox.SetBool("walk", false);
            arcticfox.SetBool("eat", false);
            arcticfox.SetBool("run", false);
            arcticfox.SetBool("trot", false);
            arcticfox.SetBool("growl", false);
            arcticfox.SetBool("turnleft", false);
            arcticfox.SetBool("turnright", false);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            arcticfox.SetBool("hunt", true);
            arcticfox.SetBool("idle", false);
            arcticfox.SetBool("eat", false);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            arcticfox.SetBool("hunt", false);
            arcticfox.SetBool("eat", true);
        }
        if (Input.GetKey("down"))
        {
            arcticfox.SetBool("walk", true);
            arcticfox.SetBool("idle", false);
            arcticfox.SetBool("eat", false);
            arcticfox.SetBool("turnleft", false);
            arcticfox.SetBool("turnright", false);
            arcticfox.SetBool("run", false);
            arcticfox.SetBool("trot", false);
            arcticfox.SetBool("trotleft", false);
            arcticfox.SetBool("trotright", false);
        }
        if (Input.GetKey("left"))
        {
            arcticfox.SetBool("turnleft", true);
            arcticfox.SetBool("walk", false);
            arcticfox.SetBool("turnright", false);
            arcticfox.SetBool("idle", false);
        }
        if (Input.GetKey("right"))
        {
            arcticfox.SetBool("turnright", true);
            arcticfox.SetBool("walk", false);
            arcticfox.SetBool("turnleft", false);
            arcticfox.SetBool("idle", false);
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            arcticfox.SetBool("run", true);
            arcticfox.SetBool("idle", false);
            arcticfox.SetBool("walk", false);
            arcticfox.SetBool("runleft", false);
            arcticfox.SetBool("runright", false);
            arcticfox.SetBool("trot", false);
            arcticfox.SetBool("trotleft", false);
            arcticfox.SetBool("trotright", false);
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            arcticfox.SetBool("runleft", true);
            arcticfox.SetBool("runright", false);
            arcticfox.SetBool("run", false);
            arcticfox.SetBool("idle", false);
            arcticfox.SetBool("walk", false);
            arcticfox.SetBool("jump", false);
            arcticfox.SetBool("trot", false);
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            arcticfox.SetBool("runright", true);
            arcticfox.SetBool("runleft", false);
            arcticfox.SetBool("run", false);
            arcticfox.SetBool("idle", false);
            arcticfox.SetBool("walk", false);
            arcticfox.SetBool("jump", false);
            arcticfox.SetBool("trot", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            arcticfox.SetBool("trot", true);
            arcticfox.SetBool("walk", false);
            arcticfox.SetBool("run", false);
            arcticfox.SetBool("idle", false);
            arcticfox.SetBool("trotleft", false);
            arcticfox.SetBool("trotright", false);
            arcticfox.SetBool("jump", false);
            arcticfox.SetBool("turnleft", false);
            arcticfox.SetBool("turnright", false);
            arcticfox.SetBool("runleft", false);
            arcticfox.SetBool("runright", false);
        }
        if (Input.GetKey(KeyCode.A))
        {
            arcticfox.SetBool("trotleft", true);
            arcticfox.SetBool("trotright", false);
            arcticfox.SetBool("trot", false);
            arcticfox.SetBool("run", false);
            arcticfox.SetBool("walk", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            arcticfox.SetBool("trotright", true);
            arcticfox.SetBool("trotleft", false);
            arcticfox.SetBool("trot", false);
            arcticfox.SetBool("run", false);
            arcticfox.SetBool("walk", false);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            arcticfox.SetBool("lay", true);
            arcticfox.SetBool("idle", false);
            StartCoroutine("idle2");
            idle2();
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            arcticfox.SetBool("up", true);
            arcticfox.SetBool("idle2", false);
            StartCoroutine("idle");
            idle();
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            arcticfox.SetBool("growl", true);
            arcticfox.SetBool("idle", false);
            arcticfox.SetBool("threat", false);
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            arcticfox.SetBool("threat", true);
            arcticfox.SetBool("growl", false);
            arcticfox.SetBool("attack", false);
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            arcticfox.SetBool("threat", false);
            arcticfox.SetBool("attack", true);
            arcticfox.SetBool("growl", false);
            arcticfox.SetBool("hit", false);
            StartCoroutine("growl");
            growl();
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            arcticfox.SetBool("run", false);
            arcticfox.SetBool("jump", true);
            arcticfox.SetBool("runleft", false);
            arcticfox.SetBool("runright", false);
            StartCoroutine("run");
            run();
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            arcticfox.SetBool("growl", false);
            arcticfox.SetBool("hit", true);
            StartCoroutine("hit");
            hit();
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            arcticfox.SetBool("growl", false);
            arcticfox.SetBool("die", true);
        }
    }
    IEnumerator idle2()
    {
        yield return new WaitForSeconds(1.5f);
        arcticfox.SetBool("lay", false);
        arcticfox.SetBool("idle2", true);
    }
    IEnumerator idle()
    {
        yield return new WaitForSeconds(2.0f);
        arcticfox.SetBool("up", false);
        arcticfox.SetBool("idle", true);
    }
    IEnumerator growl()
    {
        yield return new WaitForSeconds(1.5f);
        arcticfox.SetBool("attack", false);
        arcticfox.SetBool("growl", true);
        arcticfox.SetBool("hit", false);
    }
    IEnumerator run()
    {
        yield return new WaitForSeconds(1.0f);
        arcticfox.SetBool("jump", false);
        arcticfox.SetBool("run", true);
        arcticfox.SetBool("runleft", false);
        arcticfox.SetBool("runright", false);
    }
    IEnumerator hit()
    {
        yield return new WaitForSeconds(0.5f);
        arcticfox.SetBool("hit", false);
        arcticfox.SetBool("growl", true);
    }
}
