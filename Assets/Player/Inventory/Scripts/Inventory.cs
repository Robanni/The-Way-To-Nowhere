using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;
    private int maxItems = 4;
    private bool isFull = false;

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
        if (itemList.Count == 4) isFull = true;
    }
    public bool IsFull { get { return isFull; } }
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
