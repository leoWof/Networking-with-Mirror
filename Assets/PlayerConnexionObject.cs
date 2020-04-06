using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerConnexionObject : NetworkBehaviour
{
    public GameObject FirstPlayerUnit;
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
        GameObject go = Instantiate(FirstPlayerUnit);
        NetworkServer.Spawn(go,connectionToClient);

    }

}
