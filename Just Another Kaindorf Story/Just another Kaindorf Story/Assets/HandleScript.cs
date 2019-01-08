using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleScript : MonoBehaviour {

    public string mitHausschuhe;
    public string ohneHausschuhe;
    private DialogueManager dMan;
    public GameObject Handle;
    // Use this for initialization
    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
        if (GlobalControl.Instance.Items.Contains("Handle"))
        {
            Handle.SetActive(false);
        }

    }

    public void HandleActivated()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (GlobalControl.Instance.HausschuheAn)
            {
                dMan.ShowBox(mitHausschuhe);
               
            }
            else
            {
                dMan.ShowBox(ohneHausschuhe);
                GlobalControl.Instance.Items.Add("Handle");
                Handle.SetActive(false);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Handle.activeInHierarchy)
        {
            HandleActivated();
        }
    }
}
