using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BockScript : MonoBehaviour {

    private DialogueManager dMan;
    
  
    // Use this for initialization
    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();

    }

    private void OnTriggerStay2D(Collider2D collision)
    {


        if (Input.GetKeyUp(KeyCode.E)&&!GlobalControl.Instance.HausschuheAn)
        {
            if(GlobalControl.Instance.Items.Contains("???key")|| GlobalControl.Instance.Items.Contains("Sandwich"))
            {
                dMan.ShowBox("Das ist der Bock, unter dem das Sandwich lag");
            }
            else if(GlobalControl.Instance.sandwichMissionOn)
            {
                dMan.ShowBox("IIIIIIHHHH! Das Ding ist voll schimmlig! - Sandwich erhalten.");
                GlobalControl.Instance.Items.Add("Sandwich");
            }
        }
    }
}
