using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("right"))
        {
            transform.Translate(0, 0, -speed);

        }
        if (Input.GetKeyUp("right"))
        {
            transform.Translate(0, 0, speed);
        }
    }
}
