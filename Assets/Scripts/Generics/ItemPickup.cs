using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public ItemBase item;  // Referencia al ítem que se va a recoger
    public PlayerController playerController;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickupItem();
        }
    }

    void PickupItem()
    {
        // Aquí puedes agregar el ítem al inventario del jugador

        playerController.walkSpeed = item.walkSpeedModify;

        // Finalmente, destruimos el objeto en el mundo
        Destroy(gameObject);
    }
    

}
