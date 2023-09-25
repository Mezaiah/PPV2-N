using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager_Pescador : Villager_Base
{
    Item pescado, rawMeat, pala;
    public List<Item> GetInventoryItems()
    {
        return Inventory;
    }
    public override void SetHealth(int _Health)
    {
        Health = 650;
        base.SetHealth(Health);
        
    }

    void Start()
    {
        //crear inventario y añadir cosas, según mi idea
        //se añadió inventario 
        //SetName("Paulo");
        SetType(VillagerType.Pescador);
        SetHealth(Health);
        //CreateInventory();
        //Item rawMeet = new Item("raw Meat");
        //AddToInventory(rawMeat);
        //rawMeat.Name = "carne";
        //Debug.Log("item name: " + Inventory[0].Name);
        //Item pala = new Item("Pala");
        //pala = new Item();
        //pala.Name = "pala";
        
        
        
    }
    public void GetData()
    {
        SetName("Paulo");
        SetHealth(Health);
        //SetSelectedItem(pala);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
