using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(Input.GetKeyDown(KeyCode.E))
        FindObjectOfType<HandleScript>().HandleActivated();
    }
}
