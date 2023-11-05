using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public GameObject currentItem; // O item atual no invent�rio

    // Adicione um item ao invent�rio
    public void AddItem(GameObject item)
    {
        // Verifique se o invent�rio est� vazio
        if (currentItem == null)
        {
            currentItem = item;
            item.SetActive(false); // Desative o item no mundo
        }
    }

    // Descarte o item atual do invent�rio
    public void DiscardItem()
    {
        if (currentItem != null)
        {
            // Defina a posi��o do item como a posi��o atual do jogador
            currentItem.transform.position = transform.position;

            currentItem.SetActive(true); // Ative o item no mundo
            currentItem = null; // Limpe o item do invent�rio
        }
    }
}
