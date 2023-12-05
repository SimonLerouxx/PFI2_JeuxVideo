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


    bool canShoot = true;
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
            if(!canShoot)
            {
                return;
            }
            if (inventory.ShootBullet())
            {
                //Shoot
                GameObject bullet = Instantiate(BulletPrefabs, transform.position, transform.rotation);
                bullet.GetComponent<BulletScript>().GiveDirection(Camera.transform.forward);
                StartCoroutine(GunRecoil(attributes.GetTimeBetweenShot()));
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

    IEnumerator GunRecoil(float time)
    {
        canShoot= false;
        StartCoroutine(Recoil(time / 16, -1));
        yield return new WaitForSeconds(time/4);

        StartCoroutine(Recoil((time * 15) / 8, 1));
        yield return new WaitForSeconds((time*3) / 4);
        canShoot = true;
    }


    IEnumerator Recoil(float time,int direction)
    {
        float timeByTick = time / 60;
        int i = 0;
        while(i<60)
        {
            transform.localRotation *= Quaternion.Euler(0.25f*direction, 0, 0);
            i++;
            yield return new WaitForSeconds(timeByTick);
        }
    }
}
