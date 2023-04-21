using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muteSoundTimer : MonoBehaviour
{

    bool sound = false;

    public GameObject cell1, cell2, cell3, cell4;

    public GameObject dialog0, dialog1, dialog2, dialog3, dialog4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dialog1.SetActive(false);
        dialog2.SetActive(false);
        dialog3.SetActive(false);
        dialog4.SetActive(false);

        dialog0.SetActive(true);
        
        if (gameObject.GetComponent<AudioSource>().enabled == true)
        {
            if (sound == false)
            {
                

                cell1.GetComponent<AudioSource>().mute = true;
                cell2.GetComponent<AudioSource>().mute = true;
                cell3.GetComponent<AudioSource>().mute = true;
                cell4.GetComponent<AudioSource>().mute = true;

                

                gameObject.GetComponent<AudioSource>().mute = false;

                gameObject.GetComponent<AudioSource>().Play();

                sound = true;
                
            }
        }

        gameObject.GetComponent<muteSoundTimer>().enabled = false;

    }

}
