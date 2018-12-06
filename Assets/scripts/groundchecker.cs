using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundchecker : MonoBehaviour
{
    //ett number bara. utan decimaler.
    public int grounded;
    public int jumpDubble = 1;
    public Rigidbody2D rbody;
    public int jumpSpeed = 10;

    //när du står på marken kommer grounded var true
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Den plusas. Beroende av hur många saker du rör.
        grounded ++;
        //Om din Jump är lika med 1 så adderas din jump med 1. (Om du hoppar bara en gång i lufen)
        if (jumpDubble == 1)
        {
            jumpDubble += 1;
        }
        //Om din Jump är lika med noll (Du hoppar 2 gånger) så plusas den med två istället
        if (jumpDubble == 0)
        {
            //Jump adderas 2
            jumpDubble += 2;
        }
    }
    //När du hoppar eller går bort. så du står  i luften.
    //Om din hitbox inte träffar något så händer det under.
    private void OnTriggerExit2D(Collider2D other)
    {
        //Den miskas om du lämnar alla objekt.
        grounded --;
        //När du hoppar så blir din Jump minskat med 1 
        jumpDubble -= 1;
    }

    public void Update()
    {
        //om din Jump är lika med 1 så kan det under hända.
        if (jumpDubble == 1)
        {
            //När du trycker på space så hoppar din gubbe på y axeln.
            if (Input.GetButtonDown("Jump"))
            {
                //Du hoppar på Y-axeln
                rbody.velocity = new Vector2(
                    rbody.velocity.x,
                    jumpSpeed);
                //När du trycker på space hoppar du. Sen så minskas din jump till noll. sen kan du inte hoppa igen. tills du kommer till marken.
                jumpDubble -= 1;
            }
        }
        
    }



}
