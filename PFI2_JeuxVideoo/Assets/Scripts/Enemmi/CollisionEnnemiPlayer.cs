using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnnemiPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    Animator animator;
    bool hasCollided=false;
    void Start()
    {
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player" && !hasCollided)
        {
            hasCollided= true;
            animator.Play("Die");
            collision.gameObject.GetComponent<PlayerHealth>().RemoveHealth(1);
            StartCoroutine(Die());
            Debug.Log("col");
        }

    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
        

    }

}
