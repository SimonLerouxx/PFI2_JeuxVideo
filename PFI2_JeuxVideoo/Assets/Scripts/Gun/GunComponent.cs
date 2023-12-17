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

    float timeReload = 2.1f;

    Animator animator;
    void Start()
    {
        inventory = player.GetComponent<Inventory>();
        attributes = GetComponent<GunAttributes>();
        animator = player.GetComponent<Animator>();
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
                bullet.GetComponent<BulletScript>().GiveDirection(Camera.transform.forward + attributes.GetAccuracy());
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
            if(!canShoot)
            {
                return;
            }
            if (inventory.Reload(attributes.GetNumberBulletInGun()))
            {
                StartCoroutine(ReloadCoroutine());
                //Reload scuccesful
            }
            else
            {
                //not succesful
            }
        }


    }

    IEnumerator ReloadCoroutine()
    {
        StopCoroutine("Recoil");
        StopCoroutine("GunRecoil");
        animator.enabled = true;
       // animator.SetBool("isReloading", true);
        animator.Play("Reload");
        
        canShoot = false;
       
        yield return new WaitForSeconds(timeReload);
        //animator.SetBool("isReloading", false);

        
        //yield return new WaitForSeconds(1f);
        animator.enabled= false;
        canShoot = true;
    }

    IEnumerator GunRecoil(float time)
    {

        canShoot= false;
        StartCoroutine(Recoil(time / 16, -1));
        yield return new WaitForSeconds(time / 16);

        StartCoroutine(Recoil((time * 15) / 16, 1));
        yield return new WaitForSeconds((time * 15) / 16);
        canShoot = true;

    }


    IEnumerator Recoil(float time,int direction)
    {
        
        float timeByTick = time / 60;
        int i = 0;
        while (i<60)
        {
            transform.localRotation *= Quaternion.Euler(0.25f*direction, 0, 0);
            i++;
            yield return new WaitForSeconds(timeByTick);
        }
    }
}
