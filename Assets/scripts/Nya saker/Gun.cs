using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{//var den ska spawna
    public Transform GunPoint;
    //vad ska den spawna
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        //När du trycer på din Fire 1 så kommer det under att hända. (fire1 = W för mig)
        if (Input.GetButtonDown("Fire1"))
        {
            //Shoot kommer att hända.
            Shoot();
        }
    }

    //Vad som kommer att hända i Shoot.
    void Shoot()
    {
        //Den kommer spawna din prefab på din gunPosition.
        Instantiate(bulletPrefab, GunPoint.position, GunPoint.rotation);
    }
}
