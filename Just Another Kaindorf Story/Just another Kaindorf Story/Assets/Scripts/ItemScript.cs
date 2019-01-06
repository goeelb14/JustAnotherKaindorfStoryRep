using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{

    private DialogueManager dMan;
    public string Message;
    public string name;
    // Use this for initialization
    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();

    }

    private void OnTriggerStay2D(Collider2D collision)
    {


        if (Input.GetKeyUp(KeyCode.E))
        {
            if(!GlobalControl.Instance.Items.Contains(name)&&GlobalControl.Instance.HausschuheAn==false)
            {
                GlobalControl.Instance.Items.Add(name);
                dMan.ShowBox(Message);
            }
        }
    }
}
