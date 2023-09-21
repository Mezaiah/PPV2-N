using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager_Pescador : Villager_Base
{
    Item pala, pescado, carnePodrida;
    public List<Item> GetInventoryItems()
    {
        return Inventory;
    }


    void Start()
    {
        //crear inventario y añadir cosas, según mi idea
        //se añadió inventario 
        SetName("Paulo");
        SetHealth(50);
        SetType(VillagerType.Pescador);
        
        
        
        CreateInventory();
        Item rawMeet = new Item("raw Meat");
        AddToInventory(rawMeet);
        Debug.Log("item name: " + Inventory[0].Name);
       
        GetName();
        GetHealth();
        GetType();
    
        
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
