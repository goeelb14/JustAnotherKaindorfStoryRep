using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsController : MonoBehaviour {

    public GameObject Stairs;
	// Use this for initialization
	void Start () {
		if(!GlobalControl.Instance.StairsUnlocked)
        {
            Stairs.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
