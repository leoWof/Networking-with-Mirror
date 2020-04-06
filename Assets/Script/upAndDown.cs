using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upAndDown : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject starting_height;
    bool movement = true; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (this.transform.position.y > 7.14)
        {
            movement = false; 
        }

        if (this.transform.position.y < 5)
        {
            movement = true; 
        }

        move(movement);

    }


    void move(bool x)
    {
        if (x)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.02f, transform.position.z); 
            return; 
        }

        transform.position = new Vector3(transform.position.x, transform.position.y - 0.02f, transform.position.z);


    }
}
