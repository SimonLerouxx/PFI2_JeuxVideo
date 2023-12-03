using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeStartComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            gameObject.GetComponentInChildren<GeberateBridge>().GenerateBridge();
        }
    }
}
