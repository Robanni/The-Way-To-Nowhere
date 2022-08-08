using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private List<Transform> inventorySlots;
    private List<Transform> uiButtons;

    private void Awake()
    {
        inventorySlots = new List<Transform>();
        uiButtons = new List<Transform>();

        for(int i = 0; i < 4; i++)
        {
            inventorySlots.Add(transform.Find(("InventorySlot_" + i)));
            uiButtons.Add( inventorySlots[i].Find("UI_Item").Find("InventoryButton"));
        }
    }
    public void setInventory(Inventory inventory)
    {
        this.inventory = inventory;
        inventory.onItemListChanged += Inventory_OnItemListChanged;
        refreshItemList();
    }

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e){
        refreshItemList();
    }

    public void refreshItemList()
    {
        List < Item > inventoryItems = inventory.GetItemList();
        if (inventoryItems.Count == 0) return;

        for (int i = 0; i < uiButtons.Count; i++)
        {
            try
            {
                if (inventoryItems[i] != null)
                {
                    uiButtons[i].Find("ItemImage").GetComponent<Image>().sprite = inventoryItems[i].GetSprite();
                    uiButtons[i].Find("ItemImage").GetComponent<Image>().enabled = true;
                    continue;
                }
            }
            catch { }
            uiButtons[i].Find("ItemImage").GetComponent<Image>().sprite = null;
            uiButtons[i].Find("ItemImage").GetComponent<Image>().enabled = false;
        }
    }

    public void itemSelected(GameObject sender)
    {
        foreach(Transform button in uiButtons)
        {
            if (button.gameObject.Equals(sender))
            {
                button.Find("ItemImage").GetComponentInChildren<Image>().sprite = null;
                button.Find("ItemImage").GetComponentInChildren<Image>().enabled = false;
                inventory.removeItemFormList( uiButtons.IndexOf(button));
            }
        }
    }
}
