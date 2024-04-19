using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory<T> where T : ItemBase // Restricción de tipo T a la clase base ItemBase
{
    private Dictionary<string, T> items;

    public Inventory()
    {
        items = new Dictionary<string, T>();
    }

    public void AddItem(T item)
    {
        if (!items.ContainsKey(item.name))
        {
            items.Add(item.name, item);
        }
    }

    public T GetItem(string name)
    {
        if (items.ContainsKey(name))
        {
            return items[name];
        }
        else
        {
            return null;
        }
    }

    public void RemoveItem(string name)
    {
        if (items.ContainsKey(name))
        {
            items.Remove(name);
        }
    }

    // Otros métodos para gestionar el inventario (opcional)
}

