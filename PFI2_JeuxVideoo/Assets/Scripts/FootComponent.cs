using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FootComponent : MonoBehaviour
{

    [SerializeField] GameObject Player;
    PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement= Player.GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name!= Player.gameObject.name)
        {
            playerMovement.canJump = true;
        }
       
    }

}
