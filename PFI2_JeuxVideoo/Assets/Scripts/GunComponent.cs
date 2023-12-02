using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GunComponent : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] GameObject BulletPrefabs;

    [SerializeField] GameObject Camera;

    Inventory inventory;

    GunAttributes attributes;

    void Start()
    {
        inventory = player.GetComponent<Inventory>();
        attributes = GetComponent<GunAttributes>();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Shoot(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (inventory.ShootBullet())
            {
                //Shoot
                GameObject bullet = Instantiate(BulletPrefabs, transform.position, transform.rotation);
                bullet.GetComponent<BulletScript>().GiveDirection(Camera.transform.forward);
            }
            else
            {
                //Dont Shoot
            }
        }


    }


    public void Reload(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            if (inventory.Reload(attributes.GetNumberBulletInGun()))
            {
                //Reload scuccesful
            }
            else
            {
                //not succesful
            }
        }


    }
}
