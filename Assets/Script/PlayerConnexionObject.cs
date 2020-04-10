using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerConnexionObject : NetworkBehaviour
{
    public GameObject FirstPlayerUnit, secondPlayerUnit;
    public string[] playerChoices = { "PlayerBlueChoice", "PlayerRedChoice" };

    [SyncVar] private int playerIndex;
    


    private GameObject currentPrefab; 
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasAuthority)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                string name = hit.transform.gameObject.name;
                if (name == playerChoices[0])
                {
                    CmdUpdateIndexValue(0);


                }

                if (name == playerChoices[1])
                {
                    CmdUpdateIndexValue(1);
                }
                Debug.Log("Valeur de playerIndex au click: " + playerIndex);
                Debug.Log(name);
                CmdDestroyCubeOnClick(GameObject.Find(name));
            }

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
           
            CmdSpawnMyUnit();
        }

    }



    /////// COMMANDS ///////

    [Command]
    void CmdSpawnMyUnit()
    {
        Debug.Log("Valeur de playerIndex au spawn: " + playerIndex);
        if (playerIndex == 0)
        {
            currentPrefab = secondPlayerUnit ;
        }

        else if(playerIndex == 1)
        {

            currentPrefab = FirstPlayerUnit; 
        }
        




        GameObject go = Instantiate(currentPrefab);
        NetworkServer.Spawn(go,connectionToClient);

    }


    [Command]
    public void CmdDestroyCubeOnClick(GameObject x)
    {
        if (x & (x.name == playerChoices[0] || x.name == playerChoices[1]))
        {
            Destroy(x);
        }
        
    }

    [Command]
    void CmdUpdateIndexValue(int x)
    {
        playerIndex = x; 
    }




}
