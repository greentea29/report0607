using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;
    public KeyCode KeyTopress;
    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyTopress))
        {

            theSR.sprite = pressedImage;
        }
        if (Input.GetKeyUp(KeyTopress))
        {
            theSR.sprite = defaultImage;
        }
    }
}
