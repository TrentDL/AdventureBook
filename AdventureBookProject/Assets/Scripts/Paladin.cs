using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Paladin : Character //c5 this is a new class file using a colon to inherit from Character script "one type of inheritance"
{

    public Weapon PrimaryWeapon;


    public override void PrintStatsInfo()
    {
        Debug.LogFormat("Hail {0} - take up your {1}!", this.CharacterName, this.PrimaryWeapon.Name);
    }


                                    //ch5 pg 231
    public Paladin(string name, Weapon weapon):base(name) 
    {
       this.PrimaryWeapon = weapon; 
    }
}
