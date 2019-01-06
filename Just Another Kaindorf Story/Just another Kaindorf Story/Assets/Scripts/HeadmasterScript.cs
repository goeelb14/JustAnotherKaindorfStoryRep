using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadmasterScript : MonoBehaviour {

    public GameObject h;

    // Use this for initialization
    private void Start () {

        
        //int r= GlobalControl.Instance.random.
        int r = Random.Range(0, 4);
        if(r==1)
        {

            h.SetActive(true);
            if(!GlobalControl.Instance.HausschuheAn)
            {
                Debug.Log("hausschuhe");
                StartCoroutine(waiting());
                SceneManager.LoadScene("EndScreen");
            }
        }
        else
        {
            h.SetActive(false);
        }
        Debug.Log(r);

       
       
	}
    IEnumerator waiting()
    {
        yield return new WaitForSeconds(5);
    }
	
	// Update is called once per frame
	void Update () {
        if (!GlobalControl.Instance.HausschuheAn&&h.active)
        {
            Debug.Log("hausschuhe");
            StartCoroutine(waiting());
            SceneManager.LoadScene("EndScreen");
        }

    }
}
