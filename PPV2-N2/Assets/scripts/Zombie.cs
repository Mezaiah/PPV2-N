using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    public override void Init()
    {
        base.Init();
    }

    public override int GetHealth()
    {
        return base.GetHealth();
    }

    public override List<string> GetLoot()
    {
        return base.GetLoot();
    }

    public override void AddLoot(string Item)
    {
        base.AddLoot(Item);
    }

     void Start()
    {
        Debug.Log("iniciado");
        Init();

        AddLoot("sword");
        AddLoot("Shield");
        AddLoot("Gold");

        for (int i = 0; i < GetLoot().Count; i++)
        {
            Debug.Log(GetLoot()[i]);
        }
    }
}
