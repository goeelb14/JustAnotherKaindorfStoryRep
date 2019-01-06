using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AMTeacherScript : MonoBehaviour
{

    public string beforeWithHausschuhe;
    public string OhneHausschuhe;
    public string afterWithHausschuhe;

    public Sprite imgRight;
    public Sprite imgDownwards;
    private DialogueManager dMan;
    // Use this for initialization
    private void Start()
    {
        dMan = FindObjectOfType<DialogueManager>();

    }
    public void onTalkAboutDrinks(bool possessesWater)
    {
        this.GetComponent<SpriteRenderer>().sprite = imgRight;

        if (possessesWater)
        {
            dMan.ShowBox(afterWithHausschuhe);
            GlobalControl.Instance.Items.Remove("Water");
            GlobalControl.Instance.GymDoorOpen = true;
        }
        else
        {
            if (GlobalControl.Instance.HausschuheAn) dMan.ShowBox(beforeWithHausschuhe);
            else dMan.ShowBox(OhneHausschuhe);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {


        if (Input.GetKeyUp(KeyCode.E))
        {
            if (GlobalControl.Instance.HausschuheAn)
            {
                if (GlobalControl.Instance.Items.Contains("Water")||GlobalControl.Instance.GymDoorOpen)
                {
                    dMan.ShowBox(afterWithHausschuhe);
                }
                else
                {
                    dMan.ShowBox(beforeWithHausschuhe);
                }
            }
            else
            {
                dMan.ShowBox(OhneHausschuhe);
            }

            Vector3 p = collision.gameObject.transform.position;
            float xDif = this.transform.position.x - p.x;
            float yDif = this.transform.position.y - p.y;
            if (Math.Abs(xDif) > Math.Abs(yDif))
            {
                this.GetComponent<SpriteRenderer>().sprite = imgRight;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = imgDownwards;
            }

        }
    }
}