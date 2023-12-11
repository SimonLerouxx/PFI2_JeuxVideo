using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RunChase : TaskBT
{
    private NavMeshAgent Agent { get; set; }

    private GameObject Player { get; set; }

    const float maxTimeChasing = 10f;
    float timeSinceChasing = 0;
    float speedRunning = 5;

    public RunChase(NavMeshAgent agent, GameObject player)
    {

        Agent = agent;
        Player = player;
    }

    public override TaskState Execute()
    {
        timeSinceChasing += Time.deltaTime;

        Agent.speed = speedRunning;
        Agent.destination = Player.transform.position;

        //Trop proche pour courir
        if (Vector3.Distance(Agent.gameObject.transform.position, Agent.destination) <= 10)
        {
            return TaskState.Failure;
        }


        Debug.Log("run");
        return TaskState.Success;
        

    }
}