using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBoss : MonoBehaviour
{
    float timeToDie = 5;
    float time = 0;
    float initialSpeed = 15;
    float speed = 100;




    public void GiveDirection(Vector3 dir)
    {
        Quaternion rotation = Quaternion.LookRotation(dir, Vector3.up);
        transform.rotation = rotation;
    }

    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * initialSpeed);


        time = time + Time.deltaTime;
        if (time > timeToDie)
        {
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //Instantiate(particleSystemm, transform.position, transform.rotation);
            //Destroy(collision.gameObject);
            //Destroy(gameObject);
        }
        else
        {
            //Instantiate(particleSystemm,transform.position,transform.rotation);
            Destroy(gameObject);
        }

    }
}