using UnityEngine;

public class CollectableObject : MonoBehaviour
{
    public string itemName = "Item";
    public GameObject inputCanvas;

    public Item GetItem()
    {
        // Crie uma nova inst�ncia do item com base nas propriedades deste objeto colecion�vel
        return new Item(itemName);
    }

    // Outros m�todos e funcionalidades podem ser adicionados conforme necess�rio
}
