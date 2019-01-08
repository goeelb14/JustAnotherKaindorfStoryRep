using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessPositionGym : MonoBehaviour {

    public GameObject Princess;
	// Use this for initialization
	void Start () {
		if(GlobalControl.Instance.lastRoom.Equals("TableTennis"))
        {
            Princess.GetComponent<Transform>().position= new Vector3(1.5f, 3.5f);
        }
        else if(GlobalControl.Instance.lastRoom.Equals("SportsRoom"))
        {
            Princess.GetComponent<Transform>().position = new Vector3(-6.5f, 3.5f);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
