using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    int numberOfBulletInGun = 5;
    int numberBullet = 0;
    int numberCoins = 30;


    public bool ShootBullet()
    {
        if(numberOfBulletInGun > 0)
        {
            numberOfBulletInGun--;
            return true;
        }
        return false;
    }


    public bool Reload(int numberBulletToReload)
    {
        if(numberBulletToReload == numberOfBulletInGun)
        {
            //Gun deja plein
            return false;
        }
        if(numberBullet ==0)
        {
            //pu de balles
            return false;
        }

        if(numberBullet > numberBulletToReload-numberOfBulletInGun)
        {
            //Plus de balles que pour recharger
            numberBullet = numberBullet - (numberBulletToReload - numberOfBulletInGun);
            numberOfBulletInGun = numberBulletToReload;
            
        }
        else
        {
            //Moin de balle que le rechargement
            numberOfBulletInGun =numberOfBulletInGun+ numberBullet;
            numberBullet = 0;
            
        }
        return true;

    }

    public void AddCoins(int nb)
    {
        numberCoins = numberCoins+ nb;
    }

    public void RemoveCoins(int nb)
    {
        numberCoins = numberCoins - nb;
    }


    public int GetCoins()
    {
        return numberCoins;
    }


    public void AddBullet(int nb)
    {
        numberBullet= numberBullet + nb;
    }
    void Start()
    {
        
    }

    void Update()
    {

    }
}
