using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Fire : Sword_Base
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        SetName("Espada");
        SetType("Fuego");
        SetBaseDamage(100);
        SetTypeDamage(50);
        GetInfo();
    }

    void Update()
    {

    }
}
