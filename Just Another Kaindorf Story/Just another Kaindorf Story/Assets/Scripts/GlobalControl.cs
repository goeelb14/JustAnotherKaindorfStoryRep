using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour {

    public static GlobalControl Instance;
    public List<string> Items;
    public string lastRoom;
    public System.Boolean HausschuheAn;
    public Sprite LastPrincess;
    public AudioClip changeRoomSound;
    public bool GymDoorOpen;
    public AudioClip normalMusic;
    public AudioClip scaryMusic;
    public Random random;
    public bool sandwichMissionOn;
    public bool StairsUnlocked;
    public bool TableTennisUnlocked;
    public bool corridorUnlocked;
    public bool bookUnlocked;
    void Awake()
    {
        
        
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            random = new Random();
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }
}
