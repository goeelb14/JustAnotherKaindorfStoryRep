using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomEnter : MonoBehaviour {

    public string tagName;
   
    private string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sceneName = Application.loadedLevelName;
        Console.Write(sceneName);
        Console.Write(collision.tag);
      //  Application.
    }
}
