using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessPos : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GlobalControl.Instance.lastRoom.Equals("Basement"))
        {
            GameObject.Find("Princess").transform.position = new Vector3(-2.7f, 3.5f);
        }
        else if(GlobalControl.Instance.lastRoom.Equals("Gym"))
        {
            GameObject.Find("Princess").transform.position = new Vector3(-2.5f, 4.5f);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
