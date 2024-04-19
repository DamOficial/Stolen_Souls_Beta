using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevoItem", menuName = "Inventario2/ItemBase2")]
public class ItemBase2 : ScriptableObject
{
    public string itemName;       // Nombre del ítem
    public Sprite itemIcon;       // Icono del ítem
    public int itemID;            // ID del ítem
    public string itemDescription;  // Descripción del ítem

    public float jumpHeightModifier;

    public virtual void Use2()
    {
        // Aquí puedes implementar el comportamiento específico cuando se use el ítem
        Debug.Log("Usando " + itemName);

    }
}
