using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletStation : UpgradeStationComponent
{
    Inventory inventory;
    public override void Upgrade()
    {
        inventory.AddBullet(20);

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
        inventory = GameObject.Find("Player").GetComponent<Inventory>();
    }

    public override bool HasMax()
    {
        return false;
    }
}