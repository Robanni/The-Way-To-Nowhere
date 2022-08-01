using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory 
{
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();
        itemList.Add(new Item { itemType = Item.ItemType.HealthPotion,itemAmount = 1 }) ;
        itemList.Add(new Item { itemType = Item.ItemType.HealthPotion,itemAmount = 1 }) ;
        itemList.Add(new Item { itemType = Item.ItemType.HealthPotion,itemAmount = 1 }) ;
        itemList.Add(new Item { itemType = Item.ItemType.HealthPotion,itemAmount = 1 }) ;
    } 
    
    public void addItem(Item item)
    {
        itemList.Add(item);
    }
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
