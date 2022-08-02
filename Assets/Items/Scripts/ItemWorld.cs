using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWorld : MonoBehaviour
{
    private Item item;
    private SpriteRenderer spriteRenderer;

    public static ItemWorld SpawnItemWorld(Vector2 itemPosition,Item item)
    {
        Transform transform = Instantiate(ItemAssets.Instance.prefubItemWorld,itemPosition,Quaternion.identity);

        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();
        itemWorld.setItem(item);

        return itemWorld;
    }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void setItem(Item item)
    {
        this.item = item;
        spriteRenderer.sprite = item.GetSprite();
    }

    public Item GetItem { get { return item; } }

    public void SelfDestroy()
    {
        Destroy(gameObject);
    }
    
}
