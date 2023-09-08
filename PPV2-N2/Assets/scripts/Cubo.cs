using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{

    public string Nombre;
    public bool Damage;
    public float DamageHowMuch;
    public bool Gravity;

   public virtual void GetInfo()
    {
        Debug.Log("Cubo de: " + Nombre);
        Debug.Log("Hace daño?: " + Damage);
        Debug.Log("Cuánto daño hace: " + DamageHowMuch);
        Debug.Log("Tiene Gravedad?: " + Gravity);
    }
}
