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
        //crear inventario y a�adir cosas, seg�n mi idea
        CreateInventory();
        AddToInventory(pescado);
        AddToInventory(carnePodrida);
        CreateItemsToTrade();
        getTradeItems();
        
        //se a�adi� inventario 
        SetName("Paulo");
        SetHealth(50);
        SetType(VillagerType.Pescador);
        SetSkin(skin);
        SetSelectedItem(pala);
        
        GetName();
        GetHealth();
        GetType();
        GetSkin();
        GetSelectedItem();
        List<Item> inventoryItems = GetInventoryItems();
        getTradeItems();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
