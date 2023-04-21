using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class ObjectThrowing : MonoBehaviour
{
    
    float m_Speed;
    public float forwardForce = 2000f;
    public Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > -4.95)
        {
            rb.AddForce(forwardForce * Time.fixedDeltaTime, 0, 0);
            Invoke("disableScript", 1.5f);
        }
        
    }

    void disableScript()
    {
        gameObject.GetComponent<ObjectThrowing>().enabled = false;
    }


    

}
