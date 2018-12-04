using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //speed för enemy.
    float speed = 4f;
    //så man kan använda saken i scriptet. 
    private Rigidbody2D rBody;
    //Att i början av spelet så är "isLeft" sant.
   
    public bool isLeft = true;


    // Use this for initialization
    void Start()
    {
       //När du startar spelet så kommer din rBody att hitta en eller ta en Rigidbody.
        rBody = GetComponent<Rigidbody2D>();

    }

        //En uppdate är när det händer varje frame. Men fixed gör så att det är mycket mera långsammare. den är * DeltaTime. Den används oftast vid RigidBody. 
    private void FixedUpdate()
    {

        //om isLeft är sant så händer något.
        if (isLeft == true)
        {
            //Det gör så att " the enemy" rör sig åt ett håll, med en  viss sanbbhet. vector2 gör så att den rör sig åt det två axlaran, X och Y.
            //Den rör sig åt vänster för den är -(vector2)
            rBody.velocity = -(Vector2)transform.right * speed;
            //När isLeft = true. Så är Enemy's sacale 1,1,1. det gör så att den pekar mot vänster. Jag berätta senare.
            transform.localScale = new Vector3(1, 1, 1);
        }
        //Om den inte är true så blir den false. Och gör det som är under istället.
        else
        {
            //Gör samma som förut. Men den här gången så har den plus, och går då åt höger.
            rBody.velocity = (Vector2)transform.right * speed;
            //gör så att spriten ändrar sitt håll åt höger. 
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }



        // OnTriggerEnter2D gör så att när man går in i ett objekt eller nudar något så händer något. Det som är under. (Gäller bara 2D).
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //När enemyn nudar Invis.Wall så kommer det under att hända.
        if (collision.tag == "InvisibleWall")
        {
            //När man nudar the wall. så blir den motsattsen av va den var förut. om den var falsk blir den true. True blir falskt.
            isLeft = !isLeft;
        }
    }
}
