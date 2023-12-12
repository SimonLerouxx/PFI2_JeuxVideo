using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DestroyWall : TaskBT
{
    private BoxCollider BoxCollider { get; set; }

    NavMeshAgent agent { get; set; }

    Animator animator { get; set; }


    public DestroyWall(BoxCollider boxCollider,NavMeshAgent nav,Animator anim)
    {
        BoxCollider= boxCollider;
        agent = nav;
        animator = anim;
    }

    public override TaskState Execute()
    {
        //Attacque si proche
        if (BoxCollider.GetComponent<DetectionBoss>().seeDestructibleWall)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isCloseAttack", false);
            animator.SetBool("isRangedAttack", false);
            animator.SetBool("isRunning", false);
            return TaskState.Success;
        }



        return TaskState.Failure;

    }


}