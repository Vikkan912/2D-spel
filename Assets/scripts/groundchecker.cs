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
        if (jumpDubble == 0)
        {
            jumpDubble += 2;
        }
    }
    //När du hoppar eller går bort. så du står  i luften.
    //Om din hitbox inte träffar något så händer det under.
    private void OnTriggerExit2D(Collider2D other)
    {
        //Den miskas om du lämnar alla objekt.
        grounded --;
        
        jumpDubble -= 1;
    }

    public void Update()
    {
        if (jumpDubble == 1)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rbody.velocity = new Vector2(
                    rbody.velocity.x,
                    jumpSpeed);

                jumpDubble -= 1;
            }
        }
        
    }



}
