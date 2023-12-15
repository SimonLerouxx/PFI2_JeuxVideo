using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreBullet : UpgradeStationComponent
{

    GunChange gunChange;
    GunAttributes gunAttributes;
    const int maxBulletInGun = 30;
    public override void Upgrade()
    {
        gunAttributes.numberOfBulletInGun = gunAttributes.numberOfBulletInGun + 1;
        gunChange.AddUpperBody();

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

    public override bool HasMax()
    {
        if (gunAttributes.numberOfBulletInGun < maxBulletInGun)
        {
            return false;
        }
        return true;
    }
}