using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    
    [SerializeField] TMP_Text ammoText;
    [SerializeField] TMP_Text moneyText;

    public void UpdateAmmo(int gun, int total)
    {
        ammoText.text = gun + " / " + total;
    }

    public void UpdateMoney(int money)
    {
        moneyText.text = money.ToString();
    }

}
