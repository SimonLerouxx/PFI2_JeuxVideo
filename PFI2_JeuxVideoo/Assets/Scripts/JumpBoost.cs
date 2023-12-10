using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JumpBoost : MonoBehaviour
{
    [SerializeField] float force = 1000;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player" )
        {

            Debug.Log(other.gameObject.GetComponent<Rigidbody>().name);

            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up*force, ForceMode.Impulse);
            //collision.gameObject.GetComponent<Rigidbody>().AddExplosionForce(30000,gameObject.transform.position,3000);
        }
    }




}
