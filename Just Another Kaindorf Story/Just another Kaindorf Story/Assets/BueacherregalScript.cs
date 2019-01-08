using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BueacherregalScript : MonoBehaviour {

    private bool moving;
    private DialogueManager dMan;
    private float speed= 1f;
    private Rigidbody2D r;
    // Use this for initialization
    void Start () {
		if(GlobalControl.Instance.bookUnlocked)
        {
            GetComponent<Transform>().position = new Vector3(3.5f, 4.2f);
        }
        dMan = FindObjectOfType<DialogueManager>();
        r=this.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		if(moving)
        {
            Debug.Log(r.position.x);
            
            if(r.position.x<3.5)
            {
                
                foreach(BoxCollider2D b in this.GetComponents<BoxCollider2D>())
                {
                    b.offset += new Vector2(speed, 0);
                }
                r.velocity = new Vector2(speed, 0);
            }
            else
            {
                moving = false;
                speed = 0f;
                r.velocity = new Vector2(0, 0);
            }
        }
	}
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyUp(KeyCode.E)&&!GlobalControl.Instance.HausschuheAn&&collision.tag=="Player")
        {
            if(GlobalControl.Instance.bookUnlocked)
            {
                dMan.ShowBox("Dieses Bücherregal versteckte die Tür.");
            }
            else 
            {
                GlobalControl.Instance.bookUnlocked = true;
                dMan.ShowBox("Huch, hinter dem Regal scheint sich was zu verbergen");
                moving = true;
            }
        }
        else if(Input.GetKeyUp(KeyCode.E))
        {
            dMan.ShowBox("Ein schönes Bücherregal");
        }
    }
}
