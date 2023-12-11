using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CloseAttack : TaskBT
{
    private NavMeshAgent Agent { get; set; }

    private GameObject Player { get; set; }


    public CloseAttack(NavMeshAgent agent, GameObject player)
    {

        Agent = agent;
        Player = player;
    }

    public override TaskState Execute()
    {
        //Attacque si proche
        //Debug.Log(Vector3.Distance(Agent.gameObject.transform.position, Player.transform.position));
        if (Vector3.Distance(Agent.gameObject.transform.position, Player.transform.position) < 2)
        {
            Debug.Log("close Attack");
            return TaskState.Success;
        }



        return TaskState.Failure;

    }
}