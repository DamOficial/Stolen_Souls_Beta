using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory<T> : MonoBehaviour where T : ItemBase
{


    public static Inventory<T> instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Más de una instancia de Inventory encontrada.");
            return;
        }
        instance = this;
    }


    public List<T> items = new List<T>();  // Lista de ítems en el inventario

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void RemoveItem(T item)
    {
        items.Remove(item);
    }
    
}
