using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour {

    public static SoundEffects Instance;
    public AudioSource audio;
    public AudioClip doorSound;
    public AudioClip TextBoxSound;
    // Use this for initialization
    void Awake()
    {
        audio = GetComponent<AudioSource>();

        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
