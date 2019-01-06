using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincessInteraction : MonoBehaviour {

    private GameObject other;
    private InteractionScript otherScript;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag=="interObject")
        {
            other = collision.gameObject;
            otherScript = other.GetComponent<InteractionScript>();
        }
    }
    
}
