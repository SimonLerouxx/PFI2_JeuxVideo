using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunChange : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] GameObject Scope;
    [SerializeField] GameObject Body;
    [SerializeField] GameObject UpperBody;
    [SerializeField] GameObject Back;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScope()
    {
        Scope.SetActive(true);
    }


    public void Damage()
    {
        Body.SetActive(true);
    }
}
