using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NVSLehrerScript : MonoBehaviour
{

    public string Message;
    public Sprite right;
    public Sprite down;
    private DialogueManager dMan;
    public bool running;
    

    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
        running = false;

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyUp(KeyCode.E) && !GlobalControl.Instance.Items.Contains("???key")&&!running&&!GlobalControl.Instance.StairsUnlocked) 
        {
            dMan.ShowBox(Message);
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            //GlobalControl.Instance.StairsUnlocked = true;
            dMan.ShowBox("Er nimmt dir den Schlüssel weg und läuft davon. - GERRY HAT IHN DOCH NICHT WIRKLICH VOR MIR VERSTECKT!");
            GlobalControl.Instance.Items.Remove("???key");
            this.GetComponent<CapsuleCollider2D>().enabled = false;
            running = true;
        }

    }
    
   
}
