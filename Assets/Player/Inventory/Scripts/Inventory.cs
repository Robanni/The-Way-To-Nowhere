using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> itemList;
    private int maxItems = 5;

    public event EventHandler onItemListChanged;
    public Inventory()
    {
        itemList = new List<Item>();
    } 
    
    public void addItem(Item item)
    {
        if (itemList.Count < maxItems)
        {
            itemList.Add(item);
            onItemListChanged?.Invoke(this, EventArgs.Empty);
        }
               
    }
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
