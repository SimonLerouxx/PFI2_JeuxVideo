using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    int numberOfBulletInGun = 5;
    int numberBullet = 30;
    int numberCoins = 30;

    private UI_Manager uiManager;

    void Awake()
    {
        uiManager = GameObject­.FindWithTag("UI").GetComponent<UI_Manager>();
        uiManager.UpdateAmmo(numberOfBulletInGun, numberBullet);
        uiManager.UpdateMoney(numberCoins);
    }

    public bool ShootBullet()
    {
        if(numberOfBulletInGun > 0)
        {
            numberOfBulletInGun--;
            uiManager.UpdateAmmo(numberOfBulletInGun, numberBullet);
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
            uiManager.UpdateAmmo(numberOfBulletInGun, numberBullet);

        }
        else
        {
            //Moin de balle que le rechargement
            numberOfBulletInGun =numberOfBulletInGun+ numberBullet;
            numberBullet = 0;
            uiManager.UpdateAmmo(numberOfBulletInGun, numberBullet);

        }
        return true;

    }

    public void AddCoins(int nb)
    {
        numberCoins = numberCoins+ nb;
        uiManager.UpdateMoney(numberCoins);
    }

    public void RemoveCoins(int nb)
    {
        numberCoins = numberCoins - nb;
        uiManager.UpdateMoney(numberCoins);
    }


    public int GetCoins()
    {
        uiManager.UpdateMoney(numberCoins);
        return numberCoins;
    }


    public void AddBullet(int nb)
    {
        numberBullet= numberBullet + nb;
        uiManager.UpdateAmmo(numberOfBulletInGun, numberBullet);
    }

    void Update()
    {

    }
}
