using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeAccuracy : UpgradeStationComponent
{

    GunChange gunChange;
    GunAttributes gunAttributes;
    public override void Upgrade()
    {
        gunAttributes.accuracy= 0;
        gunChange.AddScope();
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
        type = "Précision";
        nbCoins = 30;
        textCoins.text = "" + nbCoins;
        textType.text = type;
        GameObject gun = GameObject.Find("Gun");
        gunAttributes = gun.GetComponent<GunAttributes>();
        gunChange = gun.GetComponent<GunChange>();
    }

    public override bool HasMax()
    {
        if(gunAttributes.accuracy ==0)
        {
            return true;
        }
        return false;
    }
}