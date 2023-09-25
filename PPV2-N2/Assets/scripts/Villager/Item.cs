using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public enum Effect
    {
        None = 0,
        Heal = 1,
        Damage = 2
    }


public class Item : MonoBehaviour
{

    public string Name;
    public Effect Effect;
    public Item()
    {
        Name = "";
    }

    //public Item(string _Name)
    //{
    //    Name = _Name;
       
    //}


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
