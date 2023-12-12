using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CloseAttack : TaskBT
{
    private NavMeshAgent Agent { get; set; }

    private GameObject Player { get; set; }

    Animator animator;


    public CloseAttack(NavMeshAgent agent, GameObject player, Animator anim)
    {

        Agent = agent;
        Player = player;
        animator = anim;
    }

    public override TaskState Execute()
    {
        //Attacque si proche
        //Debug.Log(Vector3.Distance(Agent.gameObject.transform.position, Player.transform.position));
        if (Vector3.Distance(Agent.gameObject.transform.position, Player.transform.position) < 2)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isCloseAttack", true);
            animator.SetBool("isRangedAttack", false);
            animator.SetBool("isRunning", false);
            return TaskState.Success;
        }



        return TaskState.Failure;

    }
}