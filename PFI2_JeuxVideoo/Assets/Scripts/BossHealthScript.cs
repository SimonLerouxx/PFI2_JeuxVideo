using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthScript : MonoBehaviour
{

    int health = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage(int damage)
    {
        health = health-damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
