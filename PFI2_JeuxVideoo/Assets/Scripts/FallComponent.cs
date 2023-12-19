using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallComponent : MonoBehaviour
{
    const float RespawnY = 40;
    [SerializeField] GameObject[] RespawnPositions;

    [SerializeField] GameObject Player;


    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <RespawnY)
        {
            float closestPosition = 100000;
            int closestPositionIndex=0;
            for (int i = 0; i < RespawnPositions.Length; i++)
            {
                if (Vector3.Distance(RespawnPositions[i].transform.position, transform.position) < closestPosition)
                {
                    closestPosition = Vector3.Distance(RespawnPositions[i].transform.position, transform.position);
                    closestPositionIndex = i;
                }
            }
            Player.GetComponent<PlayerHealth>().RemoveHealth(1);
            transform.position = RespawnPositions[closestPositionIndex].transform.position;

        }
    }
}
