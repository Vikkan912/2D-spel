using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rave : MonoBehaviour
{
    public SpriteRenderer [] rend;



    // Use this for initialization
    void Start()
    {
              print("gg,ezpz, noobs");
    }

    // Update is called once per frame
    void Update()
    {
        //for (loopar något)
        if (Input.GetKey(KeyCode.Space))
        {
            for (int i = 0; i < rend.Length; i++)
            {
           rend[i].color = Random.ColorHSV(0, 1, 0, 1, 0.8f, 1);
            }
        }
        if (Input.GetKey(KeyCode.Space))
        {

        }
    }
}
