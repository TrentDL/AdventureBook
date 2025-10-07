using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon //ch.5 
{
    public string Name;

    public int Damage;


    public Weapon(string name,int damage) //pg 219
    {
        this.Name = name;

        this.Damage = damage;

    }

    public void PrintWeaponStats() //left off pg220
    {
        Debug.LogFormat("Weapon:{0} - {1} DMG", this.Name,this.Damage);
    }


}

