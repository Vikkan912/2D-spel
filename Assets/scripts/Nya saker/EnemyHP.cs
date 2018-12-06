using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    public int enemyHealth = 30;


    // Use this for initialization
    //så din fiende kan ta damage
    public void TakeDamage(int damage)
    {
        //Enemy tar lika mycket damage som spelaren har på sin damage.
        enemyHealth -= damage;

        //När vår enemy har lika med 0 health (dens int är = 0 eller mindre) så kommer det under att hända.
        if (enemyHealth <= 0)
        {
            // När din int blir lika med noll så kommer allt i PlayDead att hända. Vi gör det till en void.
            PlayDead();
        }
    }
    //Vad som häder när PlayDead "sätts igång".
    void PlayDead ()
    {
        //Den kommer att förstöra objektet
        Destroy(gameObject);
    }
   
}
