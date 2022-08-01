using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;
    // Start is called before the first frame update
    void Awake()
    {
        inventory = new Inventory();
        uiInventory.setInventory(inventory);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
