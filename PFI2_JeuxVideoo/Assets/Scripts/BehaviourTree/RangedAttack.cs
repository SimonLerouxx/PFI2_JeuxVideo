using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RangedAttack : TaskBT
{
    private BoxCollider BoxCollider { get; set; }

    NavMeshAgent agent { get; set; }
    public RangedAttack(BoxCollider boxCollider, NavMeshAgent navMeshAgent)
    {
        BoxCollider = boxCollider;
        agent= navMeshAgent;
    }

    public override TaskState Execute()
    {
        //Attacque si proche
        if (BoxCollider.GetComponent<DetectionBoss>().seePlayer)
        {
            Debug.Log("rangedAttack");
            return TaskState.Success;
        }



        return TaskState.Failure;

    }

    
}