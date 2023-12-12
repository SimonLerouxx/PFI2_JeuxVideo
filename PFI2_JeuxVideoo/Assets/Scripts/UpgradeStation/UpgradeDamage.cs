using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeDamage : UpgradeStationComponent
{

    GunChange gunChange;
    GunAttributes gunAttributes;
    public override void Upgrade()
    {
        gunAttributes.damage = gunAttributes.damage + 1;
        GlobalVariable.DamageGun = GlobalVariable.DamageGun + 1;
        gunChange.Damage();
    }


    public override bool CanPurchase(int coinsInventory)
    {
        if(coinsInventory >= nbCoins)
        {
            return true;
        }
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        type = "Damage";
        nbCoins = 15;
        textCoins.text = "" + nbCoins;
        textType.text = type;
        GameObject gun = GameObject.Find("Gun");
        gunAttributes = gun.GetComponent<GunAttributes>();
        gunChange = gun.GetComponent<GunChange>();
    }

}
