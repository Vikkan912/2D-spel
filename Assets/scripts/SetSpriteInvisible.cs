using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // När spelet börjar så händer det här.
    void Start()
    {
        //så fort du startar spelet så stängs SpriteRenderer av. så man ser inte dem.
        GetComponent<SpriteRenderer>().enabled  = false;
        
    }

}
