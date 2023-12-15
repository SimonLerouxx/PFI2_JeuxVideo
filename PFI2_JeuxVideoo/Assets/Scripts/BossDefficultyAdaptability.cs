using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossDefficultyAdaptability : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject Player;

    int playerHealth;
    int money;
    int moneySinceStart;
    int nbBullet;

    int moneySupposed = 100;

    float difficultyMultiplier;
    void Start()
    {
        Player = GameObject.Find("Player");
        playerHealth = Player.GetComponent<PlayerHealth>().health;
        Inventory inventory = Player.GetComponent<Inventory>();
        money = inventory.numberCoins;
        nbBullet = inventory.numberBullet;
        moneySinceStart = inventory.moneySinceStart;

        float multiplyer = DifficultyMultiplierAlgorithm(playerHealth, money,nbBullet,moneySinceStart);

        GlobalVariable.speedWalk = 3 * multiplyer;
        GlobalVariable.speedRun = 5 * multiplyer;
        GlobalVariable.healthBoss = (int)(5 * multiplyer);
        GlobalVariable.coolDownRangedAttack = 15 - (multiplyer*5);
    }


    float DifficultyMultiplierAlgorithm(float playerHealth,float money,float nbBullet,float coinsSinceStart)
    {
        float multiplierHealth = playerHealth/ 3;
        float multiplierMoneyStart = coinsSinceStart / moneySupposed;
        moneySupposed = moneySupposed + 10;
        //float multipliernbBullet = nbBullet / 30;
        //float multiplierMoney = money / 30;

        Debug.Log(multiplierHealth);

        float multiplyer = (multiplierHealth * 0.5f) + (multiplierMoneyStart * 0.5f)  /*(multiplierMoney * 0.125f) + (multipliernbBullet * 0.125f)*/;
        if(multiplyer <0.5f)
        {
            multiplyer = 0.5f;
        }
        else if(multiplyer >2.5f)
        {
            multiplyer = 2.5f;
        }
        return multiplyer;
    }

}
