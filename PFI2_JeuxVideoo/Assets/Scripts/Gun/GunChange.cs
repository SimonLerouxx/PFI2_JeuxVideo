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
    [SerializeField] GameObject Muzzle;


    public void AddScope()
    {
        Scope.SetActive(true);
    }


    public void Damage()
    {
        Body.SetActive(true);
    }

    public void AddBack()
    {
        Back.SetActive(true);
    }


    public void AddUpperBody()
    {
        Muzzle.transform.localPosition = new Vector3(0, 0, -0.2f);
        UpperBody.SetActive(true);
    }
}
