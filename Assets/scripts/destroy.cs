using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

    //När något kommer nära föremålet så kommer det under att ske.
    void OnCollisionEnter2D(Collision2D collision)
    {
        //när något kolliderar med ett föremål. så ska föremålet förstöras
        Destroy(collision.collider.gameObject);
    }
  
}
