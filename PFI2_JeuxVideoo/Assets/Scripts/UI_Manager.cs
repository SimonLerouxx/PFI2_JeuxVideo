using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    
    [SerializeField] TMP_Text ammoText;
    [SerializeField] TMP_Text moneyText;
    [SerializeField] TMP_Text hpText;

    public void UpdateAmmo(int gun, int total)
    {
        ammoText.text = gun + " / " + total;
    }

    public void UpdateMoney(int money)
    {
        moneyText.text = money + "$";
    }

    public void UpdateHp(int hp)
    {
        string hpToText = "";

        if (hp == 1)
        {
           hpToText = "<sprite=0>";
        }
        else if (hp == 2)
        {
            hpToText = "<sprite=0><sprite=0>";
        }
        else if (hp == 3)
        {
            hpToText = "<sprite=0><sprite=0><sprite=0>";
        }
        else if (hp == 4)
        {
            hpToText = "<sprite=0><sprite=0><sprite=0><sprite=0>";
        }
        else if (hp == 5)
        {
            hpToText = "<sprite=0><sprite=0><sprite=0><sprite=0><sprite=0>";
        }
        else if (hp == 6)
        {
            hpToText = "<sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0>";
        }
        else if (hp == 7)
        {
            hpToText = "<sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0>";
        }
        else if (hp == 8)
        {
            hpToText = "<sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0>";
        }
        else if (hp == 9)
        {
            hpToText = "<sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0>";
        }
        else if (hp == 10)
        {
            hpToText = "<sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0><sprite=0>";
        }


        hpText.text = hpToText;
    }
}
