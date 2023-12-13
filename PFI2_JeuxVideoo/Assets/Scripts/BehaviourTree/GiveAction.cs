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

    public void Attack()
    {
        StartCoroutine(AttackDelay());
    }


    IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(1f);
        Player.GetComponent<PlayerHealth>().RemoveHealth(1);
    }
}
