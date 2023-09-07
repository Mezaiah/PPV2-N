using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public string Name = "Sam";
    public int ID = 123456;

    public virtual void GetInfo()
    {
        Debug.Log("Name: " + Name);
        Debug.Log("ID: " + ID);
    }
}
