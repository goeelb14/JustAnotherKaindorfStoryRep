using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {


    public GameObject dBox;
    public Text dText;
    public bool DialogActive;
    private void Update()
    {
        if (DialogActive && Input.GetKeyDown(KeyCode.E))
        {
            dBox.SetActive(false);
            DialogActive = false;
        }

    }
    
    public void ShowBox(string message)
    {
        Debug.Log("Hello");
        dBox.SetActive(true);
        DialogActive = true;
        dText.text = message;
        SoundEffects.Instance.audio.clip = SoundEffects.Instance.TextBoxSound;
        SoundEffects.Instance.audio.Play();
    }
}
