using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAttributes : MonoBehaviour
{

    public int numberOfBulletInGun = 5;
    public int damage = 1;
    public float timeBetweenShot = 2;
    public int accuracy = 1;
    private void Update()
    {
    }

    public int GetNumberBulletInGun()
    {
        return numberOfBulletInGun;
    }


    public float GetTimeBetweenShot()
    {
        return timeBetweenShot;
    }

    public Vector3 GetAccuracy()
    {
        if(accuracy ==0)
        {
            return Vector3.zero;
        }
        return new Vector3(Random.Range(-0.03f, 0.03f), Random.Range(-0.03f, 0.03f), 0);
    }

}
