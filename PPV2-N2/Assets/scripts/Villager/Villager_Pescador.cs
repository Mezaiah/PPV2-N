using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Villager_Pescador : Villager_Base
{
    Item pescado;
    public override void SetHealth(int _Health)
    {
        Health = 100;
    }

    public override void SetType(VillagerType _Type)
    {
        Type = VillagerType.Pescador;
    }
    public override void SetSkin(Sprite _Skin)
    {
        skin = _Skin;
    }

    
    public override void CreateInventory()
    {
        Invertory = new List<Item>();
    }
    void Start()
    {
        SetName("Paulo");
        SetSelectedItem(pescado);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
