using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int health=3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveHealth(int damage)
    {
        health = health- damage;
        if(health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    public void AddHealth()
    {
        if(health <= 10)
        {
            health++;
        }
    }
}
