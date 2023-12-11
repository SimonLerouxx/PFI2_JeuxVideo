using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class BehaviourTree : MonoBehaviour
{

    [SerializeField]
    NavMeshAgent agent;


    [SerializeField]
    BoxCollider boxCollider;


    GameObject Player;

    private Node rootBT;

    private void Awake()
    {

        Player = GameObject.Find("Player");

        TaskBT[] taskCloseAttack = new TaskBT[]
        {
            new CloseAttack(agent,Player)
        };

        TaskBT[] taskRangedAttack = new TaskBT[]
        {
            new RangedAttack(boxCollider,agent)
        };

        TaskBT[] taskDestroyWall = new TaskBT[]
        {
            new DestroyWall(boxCollider,agent)
        };


        TaskBT[] taskChase = new TaskBT[]
        {
            new Chase(agent,Player)
        };

        TaskBT[] taskRunChase = new TaskBT[]
       {
            new RunChase(agent,Player)
       };


        TaskNode closeAttackNode = new TaskNode("closeAttackNode", taskCloseAttack);
        TaskNode rangedAttackNode = new TaskNode("rangedAttackNode", taskRangedAttack);

        TaskNode destroyWallNode = new TaskNode("destrowWallNode", taskDestroyWall);

        TaskNode chaseNode = new TaskNode("chaseNode", taskChase);
        TaskNode runNode = new TaskNode("runNode", taskRunChase);

        Node AttakSelector = new Selector("AttackSelector", new[] { closeAttackNode, rangedAttackNode });
        Node MovementSelector = new Selector("MovementSelector", new[] { chaseNode, runNode });

        
        

        rootBT = new Selector("root", new[] { closeAttackNode,rangedAttackNode, destroyWallNode, chaseNode,runNode });

    }

    void Update()
    {
        rootBT.Evaluate();
    }
}