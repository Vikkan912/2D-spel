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
        rBody.velocity = transform.right * bulletSpeed;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyHP enemy = collision.GetComponent<EnemyHP>();
        if (enemy != null)
        {
            enemy.TakeDamage(takeDamageGun);
        }

        Instantiate(impactEnemy, transform.position, transform.rotation);

        Destroy(gameObject);
    }
   
}
