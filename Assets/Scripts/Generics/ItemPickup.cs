using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemBase item;  // Referencia al ítem que se va a recoger
    public ItemBase2 item2;
    public PlayerController playerController;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickupItem();
            PickupItem2();
        }
    }

    void PickupItem()
    {
        // Aquí puedes agregar el ítem al inventario del jugador
        Debug.Log("Recogiendo " + item.itemName);

        playerController.walkSpeed = item.walkSpeedModify;

        // Finalmente, destruimos el objeto en el mundo
        Destroy(gameObject);
    }
    void PickupItem2()
    {
        // Aquí puedes agregar el ítem al inventario del jugador
        Debug.Log("Recogiendo " + item2.itemName);

        playerController.jumpHeight = item2.jumpHeightModifier;

        // Finalmente, destruimos el objeto en el mundo
        Destroy(gameObject);
    }

}
