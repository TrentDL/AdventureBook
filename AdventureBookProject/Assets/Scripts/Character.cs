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

        Reset();
    }

    public Character(string name)
    {
        this.CharacterName = name;
    }



    public virtual void PrintStatsInfo() //ch 5 pg 215 // first method here //virtual is from ch5 pg 234
    {
        Debug.LogFormat("Hero: {0} - {1} EXP", this.CharacterName, this.CharacterExperiencePoints); //my variable names is a bit long
    }

    private void Reset()
    {
        this.CharacterName = "Not assigned";
        this.CharacterExperiencePoints = 0;

    }

}

public class Plumber  //c5 this is a new class inside this Character class "one type of inheritance"
{

}
