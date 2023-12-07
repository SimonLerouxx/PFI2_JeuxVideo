using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnnemiFollow : MonoBehaviour
{

    NavMeshAgent agent;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        agent= GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = Player.transform.position;
    }

    private void OnDestroy()
    {
        Player.GetComponent<Inventory>().AddCoins(1);
    }
}
