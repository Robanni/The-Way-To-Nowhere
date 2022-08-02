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

        ItemWorld.SpawnItemWorld(new Vector2(1, 1), new Item { itemType = Item.ItemType.HealthPotion, itemAmount = 1 });
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ItemWorld itemWorld = collision.GetComponent<ItemWorld>();
        if(itemWorld!= null)
        {
            inventory.addItem(itemWorld.GetItem);
            itemWorld.SelfDestroy();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
