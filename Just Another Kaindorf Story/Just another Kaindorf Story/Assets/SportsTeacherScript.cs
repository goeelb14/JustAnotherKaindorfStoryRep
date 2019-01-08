using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportsTeacherScript : MonoBehaviour {

    public Sprite down;
    public Sprite left;
    public Sprite right;
    public string secondM;
    public string firstM;
    // Use this for initialization
    private DialogueManager dMan;
	void Start () {
        dMan = FindObjectOfType<DialogueManager>();
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyUp(KeyCode.E))
        { 
        if(GlobalControl.Instance.corridorUnlocked)
        {
            dMan.ShowBox(secondM);
        }
        else
        {
            dMan.ShowBox(firstM);
            GlobalControl.Instance.corridorUnlocked = true;
            GlobalControl.Instance.Items.Remove("Handle");
        }


       
            

            Vector3 p = collision.gameObject.transform.position;
            float xDif = this.transform.position.x - p.x;
            float yDif = this.transform.position.y - p.y;
            if (xDif > 0)
            {
                if (xDif > Math.Abs(yDif))
                {
                    this.GetComponent<SpriteRenderer>().sprite = left;
                }
                else if (yDif > 0)
                {
                    this.GetComponent<SpriteRenderer>().sprite = down;
                }
                
            }
            else
            {
                if (Math.Abs(xDif) > Math.Abs(yDif))
                {
                    this.GetComponent<SpriteRenderer>().sprite = right;
                }
                else if (yDif > 0)
                {
                    this.GetComponent<SpriteRenderer>().sprite = down;
                }
                
            }
        
        }
    }
}
