using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealthScript : MonoBehaviour
{

    float health = 5;
    float startHealth = 5;

    [SerializeField] Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
    }

    // Update is called once per frame

    void Update()
    {
        
    }

    public void Damage(int damage)
    {
        health = health-damage;
        healthBar.fillAmount= health/startHealth;
        Debug.Log(health);
        Debug.Log(startHealth);
        Debug.Log(health / startHealth);
        Debug.Log(healthBar.fillAmount);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
