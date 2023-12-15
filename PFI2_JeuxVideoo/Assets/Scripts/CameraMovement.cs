using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{

    public float vitesseLook = 1.5f;
    public float lookXLimit = 45.0f;
    float rotationX;
    public float sensitivity = 40;
    float verticalRotation = 0;

    [SerializeField] GameObject Player;
    [SerializeField] GameObject Gun;

    [SerializeField] TextMeshProUGUI textInteract;

    Inventory inventory;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        inventory = Player.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {

        //Rotation X
        rotationX = Input.GetAxis("Mouse X") * vitesseLook;
        Player.transform.Rotate(Vector3.up * rotationX);


        //Rotation Y
        Vector2 rotation = Mouse.current.delta.ReadValue() * Time.deltaTime * sensitivity;
        verticalRotation = verticalRotation - rotation.y;
        verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(verticalRotation, 0, 0);


        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3f))
        {
            if(hit.transform.tag == "UpgradeStation")
            {
                UpgradeStationComponent upgradeStationComponent = hit.transform.gameObject.GetComponent<UpgradeStationComponent>();
                if (upgradeStationComponent.HasMax())
                {
                    textInteract.text = "Vous avez le maximum";
                }
                else if (upgradeStationComponent.CanPurchase(inventory.GetCoins()))
                {
                    textInteract.text = "Appuyer sur [E] pour acheter";
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        upgradeStationComponent.Upgrade();
                        inventory.RemoveCoins(upgradeStationComponent.nbCoins);
                    }

                }
                else
                {
                    textInteract.text = "Pas assez d'argent";
                }

            }
            else
            {
                textInteract.text = "";
            }


        }
        else
        {
            textInteract.text = "";
        }


    }


}

   