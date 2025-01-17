using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NuevoItem", menuName = "Inventario/ItemBase")]
public class ItemBase : ScriptableObject
{
    public string itemName;       // Nombre del ítem
    public Sprite itemIcon;       // Icono del ítem
    public int itemID;            // ID del ítem
    public string itemDescription;  // Descripción del ítem

    public float walkSpeedModify;

    public virtual void Use()
    {
        // Aquí puedes implementar el comportamiento específico cuando se use el ítem
        Debug.Log("Usando " + itemName);

    }
}
