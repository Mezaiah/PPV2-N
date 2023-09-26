using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Datos : MonoBehaviour
{
    public TextMeshProUGUI NNombre;
    public TextMeshProUGUI NHealth;
    public TextMeshProUGUI NItem;
    public TextMeshProUGUI Intercambio;
    public Item nombre_i, posesion;
    public Villager_Pescador datosP;
    // Start is called before the first frame update
    void Start()
    {
        //nombre_i.Name = "Pala";
        datosP = new Villager_Pescador();
        NNombre.text = datosP.GetName();
        NHealth.text = datosP.GetHealth().ToString();
        //Debug.Log(nombre_i.Name);
        //NItem.text = GetSelectedItem().Name;
        //NItem.text = nombre_i.Name;
        //posesion.Name = "Diamante";
        //Intercambio.text = posesion.Name;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
