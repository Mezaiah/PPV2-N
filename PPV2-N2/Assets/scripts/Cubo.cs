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
        Debug.Log("Hace da�o?: " + Damage);
        Debug.Log("Cu�nto da�o hace: " + DamageHowMuch);
        Debug.Log("Tiene Gravedad?: " + Gravity);
    }
}
