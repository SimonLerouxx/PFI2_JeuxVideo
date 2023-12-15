using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DetectionBoss : MonoBehaviour
{
    // Start is called before the first frame update
    public bool seePlayer = false;
    public bool seeDestructibleWall = false;

    Vector3 positionPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            seePlayer= true;
            positionPlayer= other.transform.position;
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


    public Vector3 GetPlayerPosition()
    {
        return positionPlayer;
    }
}
