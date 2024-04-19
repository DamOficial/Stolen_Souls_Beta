using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup1 : MonoBehaviour
{
    public ItemBase2 item2;  // Referencia al ítem que se va a recoger
    public PlayerController playerController;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickupItem2();
        }
    }

    void PickupItem2()
    {
        // Aquí puedes agregar el ítem al inventario del jugador

        playerController.jumpHeight = item2.jumpHeightModifier;

        // Finalmente, destruimos el objeto en el mundo
        Destroy(gameObject);
    }
    

}
