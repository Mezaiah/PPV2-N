using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword_Base : MonoBehaviour
{
    public string Name;
    public string Type;//se puede hacer un array para guardar tipos de elementos de da�o?
    public int TypeDamage;
    public int BaseDamage;

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetType(string type)
    {
        Type = type;
    }

    public void SetBaseDamage(int basedamage)
    {
        BaseDamage = basedamage;
    }
    public void SetTypeDamage(int typedamage)
    {
        TypeDamage = typedamage;
    }
    public void GetInfo()
    {
        Debug.Log("Objeto " + Name);
        Debug.Log("Elemento: " + Type);
        Debug.Log("Da�o: " + BaseDamage);
        Debug.Log("Da�o Elemental: " + TypeDamage);

    }

}
