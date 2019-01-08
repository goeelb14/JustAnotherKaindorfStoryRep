using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour {

    public string SceneToLoad;
    
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            
            if(SceneToLoad=="Gym"&& !GlobalControl.Instance.GymDoorOpen)
            {
                AMTeacherScript am = FindObjectOfType<AMTeacherScript>();
                if (GlobalControl.Instance.Items.Contains("Water"))
                {               
                    am.onTalkAboutDrinks(true);
                }
                else
                {
                    am.onTalkAboutDrinks(false);
                }
            }

            else if ((SceneToLoad != "ahif14" || GlobalControl.Instance.Items.Contains("ahifKey"))&&
                (SceneToLoad!="TableTennis"||GlobalControl.Instance.TableTennisUnlocked)
                &&(SceneToLoad!="SportsRoom"||GlobalControl.Instance.corridorUnlocked))
            {

                GlobalControl.Instance.LastPrincess = GameObject.Find("Princess").GetComponent<SpriteRenderer>().sprite;
                GlobalControl.Instance.lastRoom = SceneManager.GetActiveScene().name;
                SoundEffects.Instance.audio.clip = SoundEffects.Instance.doorSound;
                SoundEffects.Instance.audio.Play();
                SceneManager.LoadScene(SceneToLoad);
            }
           
        }
    }
}
