 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Health : NetworkBehaviour
{
    public const int maxHealth = 100;
    [SyncVar (hook = "onChangehealth")] public int currentHealth = maxHealth;
    public RectTransform healthBar; 


    public void takeDamage(int amount)
    {

        if (!isServer)
        {
            return;
        }
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("Dead");
        }

    }

    public void onChangehealth(int oldhealth,int newHealth)
    {
        healthBar.sizeDelta = new Vector2(newHealth * 2, healthBar.sizeDelta.y);

    }



}
