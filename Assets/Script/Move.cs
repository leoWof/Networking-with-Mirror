using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using Mirror;

public class Move : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {

        if (hasAuthority == false)
        {
            return; 
        }
      
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z+0.1f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z-0.1f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x-0.1f, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x+0.1f, transform.position.y, transform.position.z);
        }

    }
}
