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
    
    public Villager_Pescador()
    {

    }
    void Start()
    {
       
        //SetType(VillagerType.Pescador);
        //SetName("Paulo");
        //SetHealth(360);
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
        //SetSelectedItem(pala);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
