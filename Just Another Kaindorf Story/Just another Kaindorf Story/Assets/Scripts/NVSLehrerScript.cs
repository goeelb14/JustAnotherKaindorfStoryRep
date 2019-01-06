using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NVSLehrerScript : MonoBehaviour
{

    public string Message;

    private DialogueManager dMan;

    

    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            dMan.ShowBox(Message);
        }

    }
}
