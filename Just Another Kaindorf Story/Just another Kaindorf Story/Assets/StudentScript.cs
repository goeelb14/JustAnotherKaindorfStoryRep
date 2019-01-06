using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentScript : MonoBehaviour
{
    public string Message;
    public string MessageDir;
    public GameObject Student;
    public GameObject headMaster;
    private DialogueManager dMan;
    public Sprite imgDown;
    public float MoveSpeed;
    private Rigidbody2D rigidbody;
    private bool isMoving;
    // Use this for initialization
    void Start()
    {
        rigidbody =Student.GetComponent<Rigidbody2D>();
        dMan = FindObjectOfType<DialogueManager>();
        if (!GlobalControl.Instance.GymDoorOpen)
        {
            Student.SetActive(false);
        }
        else
        {
            Student.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isMoving)
        {
            rigidbody.velocity = new Vector2(0, -MoveSpeed);
            if (rigidbody.position.y < 4.8)
            {
                isMoving = false;
                if(!GlobalControl.Instance.sandwichMissionOn)
                {
                    if(!GlobalControl.Instance.Items.Contains("???key"))
                    {
                        dMan.ShowBox(Message);
                        GlobalControl.Instance.sandwichMissionOn = true;
                    }
                    else
                    {
                        dMan.ShowBox("Der Schlüssel hat mein Brot ganz labrig gemacht...");
                    }
                   
                }
                else if(GlobalControl.Instance.Items.Contains("Sandwich"))
                {
                    GlobalControl.Instance.sandwichMissionOn = false;
                    GlobalControl.Instance.Items.Remove("Sandwich");
                    GlobalControl.Instance.Items.Add("???key");
                    dMan.ShowBox("Danke! Oh wie lecker... *Spuck* Wer legt da einen Schlüssel rein? -Schlüssel erhalten.");
                }
                else
                {
                    dMan.ShowBox("WO BLEIBT MEIN ESSEN???");
                }
                
            }
        }
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(Student.activeInHierarchy);
        if (Input.GetKeyUp(KeyCode.E)&&Student.activeInHierarchy)
        {
            if(headMaster.activeInHierarchy)
            {
                Debug.Log("Hello");
                dMan.ShowBox(MessageDir);
            }
            else
            {
                Student.GetComponent<SpriteRenderer>().sprite = imgDown;
                isMoving = true;
            }
            
            
        }
    }
}
