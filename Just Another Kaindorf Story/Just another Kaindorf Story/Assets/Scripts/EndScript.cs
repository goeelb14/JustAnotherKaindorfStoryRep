using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            Application.Quit();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            GlobalControl.Instance.Items.Clear();
            GlobalControl.Instance.HausschuheAn = true;
            GlobalControl.Instance.GymDoorOpen = false;
            SceneManager.LoadScene("StartScreen");
        }
	}
}
