using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class UpgradeStationComponent : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI textType;
    public TextMeshProUGUI textCoins;


    public string type;
    public int nbCoins;


    GunChange gunChange;
    GunAttributes gunAttributes;
    void Start()
    {
        //textCoins.text = ""+nbCoins;
        //textType.text = type;
        GameObject gun = GameObject.Find("Gun");
        gunAttributes = gun.GetComponent<GunAttributes>();
        gunChange= gun.GetComponent<GunChange>();
    }


    public abstract void Upgrade();

    public abstract bool CanPurchase(int nbCoins);

    public abstract bool HasMax();
}
