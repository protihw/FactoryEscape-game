using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public MessageDisplay messageDisplay;
    public GameObject itemPrefab; // Prefab do item que pode ser coletado
    public InventorySystem inventory; // Refer�ncia ao script do invent�rio
    [SerializeField]
    private bool colliding = false;

    private void Update()
    {
        if (colliding && Input.GetKeyDown(KeyCode.E))
        {
            if (inventory && inventory.currentItem == null)
            {
                // Crie o item no invent�rio
                GameObject item = Instantiate(itemPrefab);
                inventory.AddItem(item);

                // Destrua o objeto de coleta no mundo
                Destroy(gameObject);
            }
            else
            {
                messageDisplay.ShowMessage("Voc� pode transportar apenas um item por vez.");
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            colliding = true;           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            colliding = false;
        }
    }
}
