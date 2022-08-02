using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;
    // Start is called before the first frame update
    void Start()
    {
        inventory = new Inventory();
        uiInventory.setInventory(inventory);

        for (int i = 0; i < 6; i++)
        ItemWorld.SpawnItemWorld(new Vector2(i, 1), new Item { itemType = Item.ItemType.HealthPotion, itemAmount = 1 });
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ItemWorld itemWorld = collision.GetComponent<ItemWorld>();
        Debug.Log(inventory.IsFull);
        Debug.Log("count of inventory:" + inventory.GetItemList().Count);
        if (itemWorld!= null)
        {
            if(!inventory.IsFull)
            {
                inventory.addItem(itemWorld.GetItem);
                itemWorld.SelfDestroy();
                Debug.Log("count of inventory:" + inventory.GetItemList().Count);
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
