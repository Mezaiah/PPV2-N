using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espada_Normal : Sword_Base
{
    // Start is called before the first frame update
    void Start()
    {
        SetName("Espada Normal");
        SetType("Ninguno");
        SetBaseDamage(100);
        SetTypeDamage(000);
        GetInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
