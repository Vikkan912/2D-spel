using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    private Rigidbody2D rBody;
    //Hur snabbt du rör dig.
    public float moveSpeed = 6f;
    //Hur snabbt du hoppar.
    public float jumpSpeed = 2f;
    // Så man får en variabel till Rigidbody.
    private Rigidbody2D rbody;
    // --||--
    public groundchecker hitBox;
    
    // Use this for initialization
    void Start()
    {
        //när spelet startar så tar rigidbody2d component och sätts in i variabeln "rbody".
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        //Om du använder A eller D. Så går du höger eller vänster * din movment speed. 
        rbody.velocity = new Vector2(
            Input.GetAxis(
                "Horizontal") * moveSpeed,
            rbody.velocity.y);



        //När du trycker på space så hoppar du upp * din jump speed.
        if (Input.GetButtonDown("Jump"))
        {
            //Om du står på marken. När ditt tal är större än 0. så kommer det här under att hända.
            if (hitBox.grounded > 0)
            {
                //Du hoppar upp i Y axeln. om den är större än noll. (du rör några objekt)
                rbody.velocity = new Vector2(
                    rbody.velocity.x,
                    jumpSpeed);
            }
        }


       

    }
}
