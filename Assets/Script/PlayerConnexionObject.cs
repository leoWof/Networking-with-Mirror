using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerConnexionObject : NetworkBehaviour
{
    public GameObject FirstPlayerUnit;
    public GameObject secondPlayerUnit;

    private static int prefab_id = 0;
    private GameObject currentPrefab; 
    // Start is called before the first frame update
    void Start()
    {
        CmdSpawnMyUnit();
    }

    // Update is called once per frame
    void Update()
    {

    }



    /////// COMMANDS ///////

    [Command]
    void CmdSpawnMyUnit()
    {

        if (prefab_id == 0)
        {
            currentPrefab = FirstPlayerUnit;
            prefab_id = 1;
        }

        else
        {
            currentPrefab = secondPlayerUnit; 
        }

        
    
        GameObject go = Instantiate(currentPrefab);
        NetworkServer.Spawn(go,connectionToClient);

    }

}
