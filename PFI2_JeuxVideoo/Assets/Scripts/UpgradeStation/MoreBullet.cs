using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreBullet : UpgradeStationComponent
{

    GunChange gunChange;
    GunAttributes gunAttributes;
    public override void Upgrade()
    {
        gunAttributes.numberOfBulletInGun = gunAttributes.numberOfBulletInGun + 1;

    }


    public override bool CanPurchase(int coinsInventory)
    {
        if (coinsInventory >= nbCoins)
        {
            return true;
        }
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        type = "Capacité";
        nbCoins = 5;
        textCoins.text = "" + nbCoins;
        textType.text = type;
        GameObject gun = GameObject.Find("Gun");
        gunAttributes = gun.GetComponent<GunAttributes>();
        gunChange = gun.GetComponent<GunChange>();
    }

}