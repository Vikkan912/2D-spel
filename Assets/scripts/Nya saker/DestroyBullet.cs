using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
   
    private void FixedUpdate()
    {
        // efter ett tag så förstörs objektet
        Destroy(gameObject);
    }
}
