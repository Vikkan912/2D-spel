using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //static menas att det finns I alla scripts. så om man skriver namnet i ett annat script kommer det mena det här namnt.
   
    public static int score;
    public int amount = 1;
    private float spinSpeed = 180;

    private void Update()
    {
        //det är att coinen rör sig på det olika axlarna. X,Y,Z
        transform.Rotate(100 * Time.deltaTime, spinSpeed * Time.deltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
            // om din karaktär går in i myntet. Så ska det under hända.
        if (collision.tag == "Player")
        {
            // gör så att din score adderas med sätt amount
            Coin.score += amount;

            // Den gör så att så fort du rör myntet, så sprängs det... önska jag. Den bara förstör myntet.
            Destroy(gameObject);
        }
    }
}
