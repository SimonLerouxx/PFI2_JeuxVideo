using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAttributes : MonoBehaviour
{

    int numberOfBulletInGun = 5;
    int damage = 1;
    float timeBetweenShot = 2;
    


    public int GetNumberBulletInGun()
    {
        return numberOfBulletInGun;
    }


    public float GetTimeBetweenShot()
    {
        return timeBetweenShot;
    }

}
