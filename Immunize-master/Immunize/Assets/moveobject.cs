using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float m_Speed, degreesPerSecond;
    int i = 1;

    void Start()
    {
        //Fetch the Rigidbody component you attach from your GameObject
        m_Rigidbody = GetComponent<Rigidbody>();
        //Set the speed of the GameObject
        m_Speed = 0.5f;
    }

    void Update()
    {
        if (GameObject.Find("GermSlimeTarget1"))
        {
            if (GameObject.Find("GermSlimeTarget1").transform.position.z > -1.15)
            {
                transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);

            }
            else
            {
                if (i < 80)
                {
                    transform.Rotate(0, 1, 0);
                    i++;
                }

            }
        }
        

    }
}
 