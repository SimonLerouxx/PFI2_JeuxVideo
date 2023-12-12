using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveAction : MonoBehaviour
{

    public void CreateBossBullet(GameObject bossBullet,Transform position, Vector3 direction)
    {
       GameObject bullet = Instantiate(bossBullet,position.position+ new Vector3(0,1f,0),position.rotation);
       bullet.GetComponent<BulletBoss>().GiveDirection(direction);
    }
}
