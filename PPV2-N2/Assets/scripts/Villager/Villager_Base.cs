using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum VillagerType
{
    Normal = 0,
    Pescador = 1,
    Herrero = 2
}
public class Villager_Base : MonoBehaviour
{
    public string Name = "Villager";
    public int Health = 100;
    public VillagerType Type;
    public List<Item> Inventory; 
    public List<Item> tradeItems;
    public Sprite skin;
    public Item SelectedItem;

    public virtual void SetName(string _Name)
    {
        Name = _Name;
    }
    public virtual void SetHealth(int _Health)
    {
        Health = _Health;
    }

    public virtual void SetType(VillagerType _Type)
    {
        Type = _Type;
    }
    public virtual void SetSkin(Sprite _Skin)
    {
        skin = _Skin;
    }
    public virtual void SetSelectedItem(Item _SelectedItem)
    {
        SelectedItem = _SelectedItem;
    }
    public virtual void CreateInventory()
    {
        Inventory = new List<Item>();
    }

    public virtual void AddToInventory(Item _Item)
    {
        Inventory.Add(_Item);
    }
    public virtual string GetName()
    {
        return Name;
    }
    public virtual int GetHealth()
    {
        return Health;
    }
    public virtual VillagerType GetType()
    {
        return Type;
    }
    public virtual Sprite GetSkin()
    {
        return skin;
    }

    public virtual Item GetSelectedItem()
    {
        return SelectedItem;
    }
    public virtual Item GetInventoryItem(int _index)
    {
        return Inventory[_index];
    }
    public virtual void CreateItemsToTrade()
    {
       tradeItems = new List<Item>();
    }
    public virtual List<Item> getTradeItems()
    {
        return tradeItems;
    }
    public virtual Item Trade()
    {
        return new Item();
    }
}
