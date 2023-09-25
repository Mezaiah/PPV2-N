using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Header : Villager_Pescador
{
    public TMP_Text Tipo;
    
    // Start is called before the first frame update

    public Villager_Pescador tipo;

    
    void Start()
    {


        
       
        tipo.SetType(VillagerType.Pescador);

        Debug.Log(VillagerType.Pescador);
        Tipo.text = VillagerType.Pescador.ToString();
        //Nombre = 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
