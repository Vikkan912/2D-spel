using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    public float bulletSpeed = 25f;
    public int takeDamageGun = 10;
    public Rigidbody2D rBody;
    public GameObject impactEnemy;

    // Use this for initialization
    void Start()
    {
        //Så fort spelet startar så kommer bullet att åka åt x axeln gånger sin speed
        rBody.velocity = transform.right * bulletSpeed;
    }
    //När man nudar ett objekt. Kan användas till att en text ska komma fram när man går in i ett objekt.
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Om du träffar en enemy så kommer det under att hända.
        EnemyHP enemy = collision.GetComponent<EnemyHP>();
        //Om du träffar en enemy
        if (enemy != null)
        {
            // Gör damage när du träffar en enemy. 
            enemy.TakeDamage(takeDamageGun);
        }
        //Spawnar ett nytt objekt på en position. kan användas till ex. bullets, att spawna där ditt vapen är.
        Instantiate(impactEnemy, transform.position, transform.rotation);
        //Förstör objektet när det kolliderar med något (Rör vid något)
        Destroy(gameObject);
    }
   
}
