using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NVSTeacherControl : MonoBehaviour {

    public GameObject nvsTeacher;
    public NVSLehrerScript nvsScript;
    public float speed = 4f;
    private Rigidbody2D rigidbody;
	// Use this for initialization
	void Start () {
        rigidbody = nvsTeacher.GetComponent<Rigidbody2D>();
        nvsScript = FindObjectOfType<NVSLehrerScript>();
		if(!GlobalControl.Instance.StairsUnlocked)
        {
            nvsTeacher.SetActive(true);
        }
        else
        {
            nvsTeacher.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Nvs is" + nvsScript.running);
		if(nvsScript.running)
        {
            
            if(rigidbody.position.y>-1.4)
            {
                rigidbody.velocity = new Vector2(0, -speed);
            }
            else if(rigidbody.position.x<7)
            {
                nvsTeacher.GetComponent<SpriteRenderer>().sprite = nvsScript.right;
                rigidbody.velocity = new Vector2(speed, 0);
            }
            else
            {
                nvsTeacher.SetActive(false);
                nvsScript.running = false;
                GlobalControl.Instance.StairsUnlocked = true;
            }
        }
	}
}
