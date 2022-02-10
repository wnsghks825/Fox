using UnityEngine;
using System.Collections;

public class Fennec : MonoBehaviour
{
    Animator fennec;
    private IEnumerator coroutine;
    // Use this for initialization
    void Start()
    {
        fennec = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            fennec.SetBool("walk", true);
            fennec.SetBool("threat", true);
            fennec.SetBool("idle", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("growl", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
        }
        if ((Input.GetKeyUp(KeyCode.W)) || (Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.D)) || (Input.GetKeyUp(KeyCode.F)))
        {
            fennec.SetBool("idle", true);
            fennec.SetBool("walk", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("threat", false);
            fennec.SetBool("growl", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
            fennec.SetBool("runattack", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            fennec.SetBool("turnleft", true);
            fennec.SetBool("turnright", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("idle", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            fennec.SetBool("turnright", true);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("idle", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
        }
        if ((Input.GetKeyDown(KeyCode.W)) && (Input.GetKey(KeyCode.RightShift)))
        {
            fennec.SetBool("trot", true);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("idle", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
        }
        if ((Input.GetKeyDown(KeyCode.A)) && (Input.GetKey(KeyCode.RightShift)))
        {
            fennec.SetBool("trotleft", true);
            fennec.SetBool("trotright", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("idle", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
        }
        if ((Input.GetKeyDown(KeyCode.D)) && (Input.GetKey(KeyCode.RightShift)))
        {
            fennec.SetBool("trotright", true);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("idle", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
        }
       if ((Input.GetKeyDown(KeyCode.W)) && (Input.GetKey(KeyCode.RightControl)))
         {
            fennec.SetBool("run", true);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("idle", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
            fennec.SetBool("runattack", false);
        }
        if ((Input.GetKeyDown(KeyCode.A)) && (Input.GetKey(KeyCode.RightControl)))
        {
            fennec.SetBool("runleft", true);
            fennec.SetBool("runright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("idle", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
            fennec.SetBool("runattack", false);
        }
        if ((Input.GetKeyDown(KeyCode.D)) && (Input.GetKey(KeyCode.RightControl)))
        {
            fennec.SetBool("runright", true);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("idle", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
            fennec.SetBool("runattack", false);
        }
        if((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.RightAlt)))
        {
            fennec.SetBool("sniffs", true);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffsright", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("idle", false);
        }
        if ((Input.GetKey(KeyCode.A)) && (Input.GetKey(KeyCode.RightAlt)))
        {
            fennec.SetBool("sniffsleft", true);
            fennec.SetBool("sniffsright", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("idle", false);
        }
        if ((Input.GetKey(KeyCode.D)) && (Input.GetKey(KeyCode.RightAlt)))
        {
            fennec.SetBool("sniffsright", true);
            fennec.SetBool("sniffsleft", false);
            fennec.SetBool("sniffs", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("trotright", false);
            fennec.SetBool("trotleft", false);
            fennec.SetBool("trot", false);
            fennec.SetBool("turnright", false);
            fennec.SetBool("turnleft", false);
            fennec.SetBool("walk", false);
            fennec.SetBool("idle", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fennec.SetBool("jump", true);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            fennec.SetBool("idle", false);
            StartCoroutine("run");
        }
        if (Input.GetKey(KeyCode.R))
        {
            fennec.SetBool("lay", true);
            fennec.SetBool("idle", false);
            StartCoroutine("idlelay");
        }
        if (Input.GetKey(KeyCode.R))
        {
            fennec.SetBool("getup", true);
            fennec.SetBool("idlelay", false);
            StartCoroutine("idle");
        }
        if (Input.GetKey(KeyCode.F))
        {
            fennec.SetBool("growl", true);
            fennec.SetBool("idle", false);
        }
        if ((Input.GetKey(KeyCode.W)) && (Input.GetKey(KeyCode.F)))
        {
            fennec.SetBool("threat", false);
            fennec.SetBool("attack", true);
            StartCoroutine("growl");
        }
        if (Input.GetKey(KeyCode.E))
        {
            fennec.SetBool("eat", true);
            fennec.SetBool("idle", false);
            StartCoroutine("idle");
        }
        if (Input.GetKey(KeyCode.S))
        {
            fennec.SetBool("sleep", true);
            fennec.SetBool("idlelay", false);
            StartCoroutine("sleep");
        }
        if (Input.GetKey(KeyCode.Keypad0))
        {
            fennec.SetBool("growl", false);
            fennec.SetBool("die", true);
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            fennec.SetBool("growl", false);
            fennec.SetBool("hit", true);
            StartCoroutine("growl");
        }
        if (Input.GetKey(KeyCode.F))
        {
            fennec.SetBool("runattack", true);
            fennec.SetBool("run", false);
            fennec.SetBool("runleft", false);
            fennec.SetBool("runright", false);
            StartCoroutine("run");
        }
    }
    IEnumerator run()
    {
        yield return new WaitForSeconds(0.5f);
        fennec.SetBool("run", true);
        fennec.SetBool("runleft", false);
        fennec.SetBool("runleft", false);
        fennec.SetBool("jump", false);
        fennec.SetBool("trotright", false);
        fennec.SetBool("trotleft", false);
        fennec.SetBool("trot", false);
        fennec.SetBool("turnright", false);
        fennec.SetBool("turnleft", false);
        fennec.SetBool("walk", false);
        fennec.SetBool("idle", false);
        fennec.SetBool("runattack", false);
    }
    IEnumerator idlelay()
    {
        yield return new WaitForSeconds(0.5f);
        fennec.SetBool("idlelay", true);
        fennec.SetBool("lay", false);
        fennec.SetBool("getup", false);
    }
    IEnumerator idle()
    {
        yield return new WaitForSeconds(1.0f);
        fennec.SetBool("idle", true);
        fennec.SetBool("getup", false);
        fennec.SetBool("idle", true);
        fennec.SetBool("walk", false);
        fennec.SetBool("turnleft", false);
        fennec.SetBool("turnright", false);
        fennec.SetBool("trot", false);
        fennec.SetBool("trotleft", false);
        fennec.SetBool("trotright", false);
        fennec.SetBool("run", false);
        fennec.SetBool("runleft", false);
        fennec.SetBool("runright", false);
        fennec.SetBool("threat", false);
        fennec.SetBool("growl", false);
        fennec.SetBool("eat", false);
    }
    IEnumerator growl()
    {
        yield return new WaitForSeconds(0.5f);
        fennec.SetBool("growl", true);
        fennec.SetBool("attack", false);
        fennec.SetBool("threat", false);
        fennec.SetBool("hit", false);
    }
    IEnumerator sleep()
    {
        yield return new WaitForSeconds(10.0f);
        fennec.SetBool("sleep", false);
        fennec.SetBool("idlelay", true);
    }
}
