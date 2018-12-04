using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    public int enemyHealth = 50;


    // Use this for initialization
    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {
            PlayDead();
        }
    }

    void PlayDead ()
    {
        Destroy(gameObject);
    }
   
}
