using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("left"))
        {
            transform.Translate(0,0,speed);
            
        }
        if (Input.GetKeyUp("left"))
        {
            transform.Translate(0,0,-speed);
        }
      
    }
}
