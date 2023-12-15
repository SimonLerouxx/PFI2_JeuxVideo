using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTimeBetweenShot : UpgradeStationComponent
{

    GunChange gunChange;
    GunAttributes gunAttributes;
    public override void Upgrade()
    {
        
        gunAttributes.timeBetweenShot = gunAttributes.timeBetweenShot - 0.25f;
        gunChange.AddBack();

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
        type = "Cadence";
        nbCoins = 10;
        textCoins.text = "" + nbCoins;
        textType.text = type;
        GameObject gun = GameObject.Find("Gun");
        gunAttributes = gun.GetComponent<GunAttributes>();
        gunChange = gun.GetComponent<GunChange>();
    }

    public override bool HasMax()
    {
        if(gunAttributes.timeBetweenShot <= 0)
        {
            return true;
        }
        return false;
    }
}