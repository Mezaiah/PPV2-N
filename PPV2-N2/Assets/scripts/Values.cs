using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Values : MonoBehaviour
{
    
    public Values_Container Valores;
    public string masa, valor;
    // Start is called before the first frame update
    void Start()
    {
        Valores.masa.text = masa;
        Valores.valor.text = valor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
