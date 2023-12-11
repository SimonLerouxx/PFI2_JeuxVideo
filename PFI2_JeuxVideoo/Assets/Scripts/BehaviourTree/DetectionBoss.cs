using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DetectionBoss : MonoBehaviour
{
    // Start is called before the first frame update
    public bool seePlayer = false;
    public bool seeDestructibleWall = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            seePlayer= true;
        }
        else if(other.gameObject.tag == "destructibleWall")
        {
            seeDestructibleWall= true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        seeDestructibleWall = false;
        seePlayer = false;
    }
}
