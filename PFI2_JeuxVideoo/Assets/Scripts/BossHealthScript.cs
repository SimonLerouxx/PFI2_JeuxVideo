using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthScript : MonoBehaviour
{

    float health = GlobalVariable.healthBoss;
    float startHealth = GlobalVariable.healthBoss;
    bool gotHealth = false;

    [SerializeField] Image healthBar;

    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player =GameObject.Find("Player");
    }

    // Update is called once per frame

    void Update()
    {
        
    }

    public void Damage(int damage)
    {
        if(!gotHealth)
        {
            gotHealth = true;
            startHealth= GlobalVariable.healthBoss;
            health = GlobalVariable.healthBoss;
        }
        health = health-damage;
        healthBar.fillAmount= health/startHealth;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        Player.GetComponent<Inventory>().AddCoins(10);
    }


}
