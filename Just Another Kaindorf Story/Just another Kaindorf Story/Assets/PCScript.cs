using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCScript : MonoBehaviour {

    public string bevor;
    public string danach;
    private DialogueManager dMan;
    // Use this for initialization
    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (!GlobalControl.Instance.Items.Contains("BlackMail-USBStick")&&GlobalControl.Instance.HausschuheAn)
            {
                dMan.ShowBox(bevor);
                GlobalControl.Instance.Items.Add("BlackMail-USBStick");
            }
            else
            {
                dMan.ShowBox(danach);
            }
        }
    }

}
