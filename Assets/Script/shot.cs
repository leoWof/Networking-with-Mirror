using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : NetworkBehaviour
{
    public GameObject ammo;
    public GameObject bulletSpawn; 
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

        if (Input.GetKeyUp(KeyCode.Space))
        {
            CmdShotBullet();
        }
        
    }


    [Command]
    void CmdShotBullet()
    {
        GameObject bullet = (GameObject)Instantiate(ammo, bulletSpawn.transform.position,bulletSpawn.transform.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward *-2f;
        NetworkServer.Spawn(bullet, base.connectionToClient);
        Destroy(bullet, 2);
    }
}
