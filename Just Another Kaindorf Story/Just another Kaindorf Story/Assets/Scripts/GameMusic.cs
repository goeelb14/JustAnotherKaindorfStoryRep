using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{

    public static GameMusic Instance;
    public AudioSource audio;
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
