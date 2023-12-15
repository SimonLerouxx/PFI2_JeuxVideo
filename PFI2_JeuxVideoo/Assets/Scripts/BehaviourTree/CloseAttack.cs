using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CloseAttack : TaskBT
{
    private NavMeshAgent Agent { get; set; }

    private GameObject Player { get; set; }


    GiveAction giveAction;

    Animator animator;

    public CloseAttack(NavMeshAgent agent, GameObject player, Animator anim,GiveAction action)
    {

        Agent = agent;
        Player = player;
        animator = anim;
        giveAction = action;
    }

    public override TaskState Execute()
    {
        //Attacque si proche
        //Debug.Log(Vector3.Distance(Agent.gameObject.transform.position, Player.transform.position));
        if (Vector3.Distance(Agent.gameObject.transform.position, Player.transform.position) < 1.5f)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isCloseAttack", true);
            animator.SetBool("isRangedAttack", false);
            animator.SetBool("isRunning", false);
            giveAction.Attack(Player);
            return TaskState.Success;
        }



        return TaskState.Failure;

    }
}