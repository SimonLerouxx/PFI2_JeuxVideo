using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletScript : MonoBehaviour
{

    float timeToDie = 2;
    float time = 0;
    float initialSpeed = 100;
    float speed = 100;

    [SerializeField] GameObject particleSystemm;



    public void GiveDirection(Vector3 dir)
    {
        Quaternion rotation = Quaternion.LookRotation(dir, Vector3.up);
        transform.rotation = rotation;
    }

    void Update()
    {
        speed = initialSpeed - (time * 20);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        time = time + Time.deltaTime;
        if (time > timeToDie)
        {
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ennemi")
        {
            //Instantiate(particleSystemm, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else if(collision.gameObject.tag == "Boss")
        {
            collision.gameObject.GetComponent<BossHealthScript>().Damage(GlobalVariable.DamageGun);
            Destroy(gameObject);
        }
        else
        {
            //Instantiate(particleSystemm,transform.position,transform.rotation);
            Destroy(gameObject);
        }

    }
}
