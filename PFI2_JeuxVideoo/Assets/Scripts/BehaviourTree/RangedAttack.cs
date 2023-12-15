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



    //float cooldown=15;
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
        Debug.Log(GlobalVariable.coolDownRangedAttack);
        if(time < GlobalVariable.coolDownRangedAttack)
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
            Vector3 dir = (BoxCollider.GetComponent<DetectionBoss>().GetPlayerPosition()- (agent.transform.position+new Vector3(0,1,0))).normalized;
            giveAction.CreateBossBullet(BulletBoss, agent.transform, dir);

            return TaskState.Success;
        }



        return TaskState.Failure;

    }

    
}