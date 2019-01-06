using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicChanger : MonoBehaviour {

    public AudioClip NewMusic;
    // Use this for initialization
    void Awake()
    {
        if(GameMusic.Instance!=null)
        { 
        if(NewMusic!=GameMusic.Instance.audio.clip)
        {
            GameMusic.Instance.audio.clip=NewMusic;
            GameMusic.Instance.audio.Play();
        }
        }
    }
}
