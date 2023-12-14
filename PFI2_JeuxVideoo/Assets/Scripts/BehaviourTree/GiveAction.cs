using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveAction : MonoBehaviour
{
    GameObject Player;

    private void Start()
    {
        Player = GameObject.Find("Player");
    }
    public void CreateBossBullet(GameObject bossBullet,Transform position, Vector3 direction)
    {
       GameObject bullet = Instantiate(bossBullet,position.position+ new Vector3(0,1f,0),position.rotation);
       bullet.GetComponent<BulletBoss>().GiveDirection(direction);
    }

    public void Attack(GameObject Player)
    {
        StartCoroutine(AttackDelay(Player));
    }


    IEnumerator AttackDelay(GameObject Player)
    {
        yield return new WaitForSeconds(1f);
        if(Vector3.Distance(transform.position, Player.transform.position) < 3)
        {
            Player.GetComponent<PlayerHealth>().RemoveHealth(1);
        }
        
    }
}
