using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportsTeacherControl : MonoBehaviour {

    public GameObject teacher;
    
	// Use this for initialization
	void Start () {
		if(!GlobalControl.Instance.Items.Contains("Handle")&&!GlobalControl.Instance.corridorUnlocked)
        {
            teacher.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
