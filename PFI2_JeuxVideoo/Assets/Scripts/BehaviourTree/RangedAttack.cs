using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RangedAttack : TaskBT
{
    private BoxCollider BoxCollider { get; set; }

    Animator animator;
    NavMeshAgent agent { get; set; }

    GameObject BulletBoss;

    GiveAction giveAction;

    float cooldown=15;
    float time = 0;
    public RangedAttack(BoxCollider boxCollider, NavMeshAgent navMeshAgent, Animator anim, GameObject bulletBoss,GiveAction giveAction)
    {
        BoxCollider = boxCollider;
        agent = navMeshAgent;
        animator = anim;
        BulletBoss = bulletBoss;
        this.giveAction = giveAction;
    }

    public override TaskState Execute()
    {

        time = time+ Time.deltaTime;
        if(time < cooldown)
        {
            animator.SetBool("isRangedAttack", false);
            return TaskState.Failure;
        }
        //Attacque si proche
        if (BoxCollider.GetComponent<DetectionBoss>().seePlayer)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isCloseAttack", false);
            animator.SetBool("isRangedAttack", true);
            animator.SetBool("isRunning", false);
            agent.destination = agent.transform.position;
            time = 0;

            giveAction.CreateBossBullet(BulletBoss, agent.transform, agent.transform.forward);

            return TaskState.Success;
        }



        return TaskState.Failure;

    }

    
}