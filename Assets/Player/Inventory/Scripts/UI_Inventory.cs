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
        refreshItemList();
    }
    public void refreshItemList()
    {
        List < Item > inventoryItems = inventory.GetItemList();

        for(int i = 0; i < inventorySlots.Count; i++)
        {
            uiButtons[i].Find("ItemImage").GetComponent<Image>().sprite = inventoryItems[i].GetSprite();
            uiButtons[i].Find("ItemImage").GetComponent<Image>().enabled = true;
        }
    }
}
