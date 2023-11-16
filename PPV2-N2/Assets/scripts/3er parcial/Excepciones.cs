using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excepciones : MonoBehaviour
{

    int divide(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            throw new DivideByZeroException("No se puede. U Wey.");
        }
        return a / b;
    }

    int getArrayValue(int[] array , int index)
    {
        if (index < 0 || index >= array.Length)
        {
            throw new IndexOutOfRangeException("index fuera de rango. Wey.");
        }
        return  array[index];
    }

    int CastStringToInt(string _str)
    {
        return int.Parse(_str);
    }
    // Start is called before the first frame update
    void Start()
    {
        //divide by zero
        try
        {
            int result = divide(10, 20);
            Debug.Log("resultado: " + result);
        }
        catch (DivideByZeroException e)
        {
            Debug.LogError("error: " + e.Message);
        }

       

        //get value from index
        //usar excepciones para encontrar errores en el codigo cuando se esta trabajando en equipo.
        
        try
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int val = getArrayValue(array, 0);
            Debug.Log("valor obtenido: " + val);
        }
        catch (IndexOutOfRangeException e2) 
        {
            Debug.LogError("nel prro, " + e2.Message);

        }

        try
        {
            string str = "6";
            int res = CastStringToInt(str);
            Debug.Log("int convertido : " + res);
        }
        catch (FormatException e3) 
        {
            Debug.LogError("estas wey, detalles: " + e3.Message);
        }
        catch (Exception e4)
        {
            Debug.LogError("error general, detalles: " + e4.Message);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
