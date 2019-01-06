using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBoardScript : MonoBehaviour {

    public string mitSchuhen;
    public string ohneSchuhe;
    private DialogueManager dMan;
    // Use this for initialization
    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();

    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (GlobalControl.Instance.HausschuheAn)
            {
                dMan.ShowBox(mitSchuhen);
            }
            else
            {
                dMan.ShowBox(ohneSchuhe);
            }
        }
    }
}
