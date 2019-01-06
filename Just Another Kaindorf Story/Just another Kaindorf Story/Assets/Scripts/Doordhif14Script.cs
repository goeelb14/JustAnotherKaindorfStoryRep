using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doordhif14Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.DebugBreak();
        Debug.Log("HEllo");

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HEllo");
        
    }
}
