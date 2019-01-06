using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDialogScript : MonoBehaviour {

    public GameObject dBox;
    public Text Hausschuhtext;
    public Text ItemText;
    public bool DialogActive;
    private void Update()
    {

         if (DialogActive && Input.GetKeyUp(KeyCode.Q))
        {
            dBox.SetActive(false);
            DialogActive = false;
        }
        else if (!DialogActive&& Input.GetKeyUp(KeyCode.Q))
        {
            if(GlobalControl.Instance.HausschuheAn)
            {
                Hausschuhtext.text = "Für Hausschuhe ausziehen\nE drücken";
            }
            else
            {
                Hausschuhtext.text = "Für Hausschuhe anziehen\nE drücken";
            }
            string erg = "Liste aller Items:";
            
            foreach(string s in GlobalControl.Instance.Items)
            {
                erg = erg + "\n" + s;
            }
            ItemText.text = erg;
            dBox.SetActive(true);
            DialogActive = true;
        }
        
        else if(DialogActive&&Input.GetKeyDown(KeyCode.E))
        {
            GlobalControl.Instance.HausschuheAn = !GlobalControl.Instance.HausschuheAn;
            if(GlobalControl.Instance.HausschuheAn)
            {
                Hausschuhtext.text = "Für Hausschuhe ausziehen\nE drücken";
            }
            else
            {
                Hausschuhtext.text = "Für Hausschuhe anziehen\nE drücken";
            }
        }
        

    }
}
