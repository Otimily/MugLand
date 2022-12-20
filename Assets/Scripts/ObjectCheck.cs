using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCheck : MonoBehaviour
{
    public Person p1;
    public Person p2;

    void Start()
    {
        Introduce(p1);
        Introduce(p2);
    }

    void Introduce(Person p)
    {
        Debug.Log(p.Name);
        Debug.Log(p.age);
        Debug.Log(p.height);
        Debug.Log(p.woman);
        Debug.Log(p.adress);
        Debug.Log(p.cookingdomlevel);
        Debug.Log(p.walk);
        Debug.Log(p.masteruser);
    }

    void Eat(Lunch L)
    {
        Debug.Log(L.Name);
        Debug.Log(L.count);
        Debug.Log(L.energy);
        Debug.Log(L.matang);
    }
}
