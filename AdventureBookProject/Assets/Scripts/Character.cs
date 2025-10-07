using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Character //ch 5 code

{
    public string CharacterName;
    public int CharacterExperiencePoints;
    public Character()
    {
        CharacterName = "Not assigned";
    }

    public Character(string name)
    {
        this.CharacterName = name;
    }



    public void PrintStatsInfo() //ch 5 pg 215 // first method here
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", this.CharacterName, this.CharacterExperiencePoints); //my variable names is a bit long
    }



}
