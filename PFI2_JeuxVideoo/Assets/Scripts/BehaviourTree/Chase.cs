using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : TaskBT
{
    private NavMeshAgent Agent { get; set; }

    private GameObject Player { get; set; }

    Animator animator;

    const float maxTimeChasing = 10f;
    float timeSinceChasing = 0;
    float speedWalking = 3;

    public Chase(NavMeshAgent agent, GameObject player,Animator anim)
    {

        Agent = agent;
        Player = player;
        animator = anim;
    }

    public override TaskState Execute()
    {
        timeSinceChasing+= Time.deltaTime;

        Agent.speed = speedWalking;
        Agent.destination = Player.transform.position;

        //Trop loin pour courir
        if(Vector3.Distance(Agent.gameObject.transform.position, Agent.destination) > 10)
        {
            return TaskState.Failure;
        }

        animator.SetBool("isWalking", true);
        animator.SetBool("isCloseAttack", false);
        animator.SetBool("isRangedAttack", false);
        animator.SetBool("isRunning", false);
        return TaskState.Success;

    }
}