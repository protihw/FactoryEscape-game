using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private static PlayerInventory instance;
    public static PlayerInventory Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerInventory>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("PlayerInventory");
                    instance = obj.AddComponent<PlayerInventory>();
                }
            }
            return instance;
        }
    }

    public List<Item> inventory = new List<Item>();

    public void AddItem(Item item)
    {
        if (inventory.Contains(item))
        {
            Debug.Log(">>> Voc� possui esse item em seu invent�rio: " + item.itemName);
        }
        else
        {
            inventory.Add(item);
            Debug.Log("Item adicionado ao invent�rio: " + item.itemName);
        }
    }

    public void RemoveItem(Item item)
    {
        if (inventory.Contains(item))
        {
            inventory.Remove(item);
            Debug.Log("Item removido do invent�rio: " + item.itemName);
        }
        else
        {
            Debug.LogWarning("Voc� n�o possui esse item em seu invent�rio:: " + item.itemName);
        }
    }
}
