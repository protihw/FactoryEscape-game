using UnityEngine;
using UnityEngine.UI;

public class ItemDiscard : MonoBehaviour
{
    public MessageDisplay messageDisplay;
    public InventorySystem inventory; // Refer�ncia ao script do invent�rio

    private void Update()
    {
        if (inventory.currentItem != null && Input.GetKeyDown(KeyCode.Q))
        {
            inventory.DiscardItem();
        }
        else if (inventory.currentItem == null && Input.GetKeyDown(KeyCode.Q))
        {
            messageDisplay.ShowMessage("Voc� n�o possui nenhum item no momento.");
        }
    }
}
