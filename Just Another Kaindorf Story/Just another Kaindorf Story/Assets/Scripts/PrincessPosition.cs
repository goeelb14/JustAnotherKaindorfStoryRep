using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(GlobalControl.Instance.lastRoom.Equals("bhif14"))
        {
            GameObject.Find("Princess").transform.position = new Vector3(1.5f, 2.4f);
        }
        else if(GlobalControl.Instance.lastRoom.Equals("LowerFloor"))
        {
            GameObject.Find("Princess").transform.position = new Vector3(5f, -1.5f);
        }
        else if(GlobalControl.Instance.lastRoom.Equals("ahif14"))
        {
            GameObject.Find("Princess").transform.position = new Vector3(-5.5f,2.4f);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
