using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour {

    public String Message;
    public Boolean talks;
    private DialogueManager dMan;

    public Sprite imgDownwards;
    public Sprite imgSidewaysLeft;
    public Sprite imgBackwards;
    public Sprite imgSidewaysRight;

    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();
       
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
            
          if(Input.GetKeyUp(KeyCode.E))
          {
            Debug.Log("ich bin getriggert");
                dMan.ShowBox(Message);

               Vector3   p = collision.gameObject.transform.position;
            float xDif = this.transform.position.x - p.x;
            float yDif = this.transform.position.y - p.y;
            if(xDif>0)
            {
                if(xDif>Math.Abs(yDif))
                {
                    this.GetComponent<SpriteRenderer>().sprite = imgSidewaysLeft;
                }
                else if(yDif>0)
                {
                    this.GetComponent<SpriteRenderer>().sprite = imgDownwards;
                }
                else
                {
                    this.GetComponent<SpriteRenderer>().sprite = imgBackwards;
                }
            }
            else
            {
                if (Math.Abs(xDif) > Math.Abs(yDif))
                {
                    this.GetComponent<SpriteRenderer>().sprite = imgSidewaysRight;
                }
                else if (yDif > 0)
                {
                    this.GetComponent<SpriteRenderer>().sprite = imgDownwards;
                }
                else
                {
                    this.GetComponent<SpriteRenderer>().sprite = imgBackwards;
                }
            }
          }
    }


}
