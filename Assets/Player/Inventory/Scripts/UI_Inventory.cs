using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private List<Transform> inventorySlots;
    private List<Transform> uiItem;

    private void Awake()
    {
        inventorySlots = new List<Transform>();
        uiItem = new List<Transform>();

        for(int i = 0; i < 4; i++)
        {
            inventorySlots.Add(transform.Find(("InventorySlot_" + i)));
            uiItem.Add( inventorySlots[i].Find("UI_Item"));
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
            uiItem[i].Find("ItemImage").GetComponent<Image>().sprite = inventoryItems[i].GetSprite();
            uiItem[i].Find("ItemImage").GetComponent<Image>().enabled = true;
        }
    }
}
