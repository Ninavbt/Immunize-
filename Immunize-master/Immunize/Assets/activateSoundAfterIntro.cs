using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateSoundAfterIntro : MonoBehaviour
{
    bool introFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (introFinished == false)
        {
            Invoke("activateSound", 25f);
        }
    }

    public void activateSound()
    {
        introFinished = true;
        gameObject.GetComponent<AudioSource>().enabled = true;
    }
}
