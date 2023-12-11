using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestroyWall : TaskBT
{
    private BoxCollider BoxCollider { get; set; }

    NavMeshAgent agent { get; set; }


    public DestroyWall(BoxCollider boxCollider,NavMeshAgent nav)
    {
        BoxCollider= boxCollider;
        agent = nav;
    }

    public override TaskState Execute()
    {
        //Attacque si proche
        if (BoxCollider.GetComponent<DetectionBoss>().seeDestructibleWall)
        {
            Debug.Log("Breack wall");
            return TaskState.Success;
        }



        return TaskState.Failure;

    }


}