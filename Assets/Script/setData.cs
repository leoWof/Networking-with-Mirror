using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setData : MonoBehaviour
{
    public int intToPass; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        GameObject.Find("playerData").GetComponent<playerData>().playerIndex = intToPass;
    }



}


