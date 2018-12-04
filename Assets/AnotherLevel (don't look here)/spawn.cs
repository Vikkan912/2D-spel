using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject spawnObject;
    //var, hur, när, vad



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            for (int i = 0; i < 100; i++)
            {
                Instantiate(spawnObject, spawnPoints[Random.Range (0, spawnPoints.Length)].position, Quaternion.identity);
            }
    }
}
