using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo_Lava : Cubo
{

    public override void GetInfo()
    {
        Nombre = "lava";
        Damage = true;
        DamageHowMuch = 1.5f;
        Gravity = true;
        base.GetInfo();
    }
    void Start()
    {
        GetInfo();
    }

   
}
