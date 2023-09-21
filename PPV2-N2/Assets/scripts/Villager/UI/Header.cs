using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Header : Villager_Pescador
{
    public TMP_Text Nombre;
    // Start is called before the first frame update

    public Villager_Pescador tipo;

    
    void Start()
    {
        tipo.GetType();
        Debug.Log(GetType());
        //Nombre = 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
