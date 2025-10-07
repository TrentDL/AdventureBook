using JetBrains.Annotations;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LearningScriptsForUnity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int CurrentAge = 30;
    public int AddedAge = 1;
    public string FirstName = "Phil"; //Ch. 3 code
    public int CurrentAge2; //ch.3 code
    public float Pi = 3.14f; //ch.3 code
    public bool CanRun = true; //ch.3 code
    public int MaximumPlayerHealth = 100;
    string FullName = "Harryson" + "Ferrone"; //ch.3 code
    public int CurrentGold = 32; //ch4.
    public bool HasDungeonKey = false;
    public string WeaponType = "R orb"; //Other names for testing: magic marker, R Orb, Binary Stick, ChezKoff, GECK // ch4
    public bool WeaponEquipped = true; //ch4

    public string TheseCanOnlyHoldTheirAssignedType = "mono"; //  i am using Pascal case for this long variable name

    /// Ch4 -------------------------
    public bool PureOfHeart = true;
    public bool HasSecretKnowledge = false;
    public string RareItem = "magic marker";

    public string CharacterAction = "attack";

    public int Dice = 7;

    //---ch. 4 arrays ----

    // array example from book: elementType[] name = new elementType[numberOfElements];

    //these right brackets are index as well as left?
    int[,,] TopPlayersScores = new int[3, 2, 2];





    /* -- dictionaries ch.4 --- */
    Dictionary<string, int> ItemInventory = new  //unity inspector does not support dictionaries 
    Dictionary<string, int>()
    {
        {"Potion",1 },{"StringItem2",7 },{"StringItem3",8 }
    };
    // -- while loops ch. 4 ---
    public int PlayerHearts = 3;

   // --------- ch 5 ----------
    //n/a
    


    void Start()

    {



        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("stinky", characterLevel);
        Debug.Log(nextSkillLevel);//ch.3 code
        Debug.Log(GenerateCharacter("Fake", characterLevel));//ch.3 code

        //Debug.Log(FirstName * Pi); // this debug is to showing arithmetic operators in console window

        Debug.Log(30 + 1); Debug.Log(CurrentAge + 1);

        Debug.Log($"this string");

        Debug.Log($"A string can have varies like {FirstName} inserted directly");//ch.3 code

        ComputeAge();

        MethodName();   //ch.3 code

        UniqueName(CanRun, FullName);

        GenerateCharacter("stinky", characterLevel);

        Thievery(); //ch 4 code

        CheckItems(); // ch4 code

        OpenTreasureChamber();

        PrintCharacterAction();

        RollDice();


        int numberOfPotions = ItemInventory["Potion"] = 5; // ch.4 (pg. 184) /* updates the ItemInventory
                                                           // dictionary element 'Potion' value from 1 to 6 ?
                                                           // but where is this ACTUALLY supposed to go? */

        Debug.LogFormat("Items: {0}", ItemInventory.Count); //same deal as note 1, for this


        foreach (KeyValuePair<string, int> kvp in ItemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}RopsaCoin", kvp.Key, kvp.Value);
        }




        FindPartyMember();

        HealthStatus();



        Character hero = new Character(); //ch5 code // object 1 "Since hero and heroine are both separate objects.." or for ex two characters
        hero.PrintStatsInfo();   
        Character heroine = new Character("agatha"); //object 2
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();

    }

    // Update is called once per frame

    /// <summary>
    /// The secret sauce
    /// </summary>
    /// 
    void Update()
    {


    }

    public void RollDice() //ch.4 pg. 165
    {
        switch (Dice)
        {
            case 7:

            case 15:
                Debug.Log("Mediocre damage, not bad...");
                break;
            case 20:
                Debug.Log("Critical Hit!, the creature dies!");
                break;
            default:
                Debug.Log("You missed!");
                break;

        }
    }

    public void PrintCharacterAction() //ch.4
    {
        switch (CharacterAction)
        {
            case "heal":
                Debug.Log("replenished");
                break;
            case "attack":
                Debug.Log("We have contact!");
                break;

            default:
                Debug.Log("Caution");
                break;
        }
    }

    public void OpenTreasureChamber()
    {
        if (PureOfHeart && RareItem == "magic marker") //evaluates if these 2 things are true
        {
            if (!HasSecretKnowledge) //is knowledge the only thing checked?
            {
                Debug.Log("You've got heart and strength, but not the knowledge"); //its not //what about a log if only heart is not true? prob use a NOT operator
            }
            else
            {
                Debug.Log("Good job, you have been chosen..."); //only if all variables are true 
            }


        }
        else
        {
            Debug.Log("GO AWAY!"); //if any one of the variables are not true //what about a log if only rareItem is not true? prob use a NOT operator
        }
    }

    public void MethodName() //ch.3 code
    {
        Debug.LogFormat("Text goes here, add {0} and {1} as variable " +
            "placeholders", CurrentAge, FirstName);
    }

    public void CheckWeapon()
    {

    } // empty
    public void CheckItems()
    {
        if (!HasDungeonKey)
        {
            Debug.Log("YOU CAN COME IN WITHOUT THE REQUIRED ITEM, BUT BE WARNED!"); // check the "haskey" box in editor and this message will be ignored
        }
        if (WeaponType != "Chez Burger")
        {
            Debug.Log("You do not have the right gear...");
        }
    }

    public void Thievery()
    {
        if (CurrentGold > 50)
        {
            Debug.Log("Your rolling in it!");
        }
        else if (CurrentGold < 15)
        {
            Debug.Log("Not much there to steal...");
        }
        else
        {
            Debug.Log("seems the purse is in the sweet spot");
        }


    } //ch.4
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }


    private void UniqueName(bool CanRun, string FullName) //ch.3 pg 125 code // with parameters 
    {

    }

    private void UniqueName2() //ch.3 pg 125 code // without parameters
    {

    }

    public int GenerateCharacter(string name, int level) //ch.3 pg 125 code 
    {
        //Debug.LogFormat("Character: {0} - Level: {1}", name,level);
        return level += 5;
    }

    public void FindPartyMember()
    {



        // --- lists ch.4 ----
        List<string> PlayerFollowers = new
        List<string>()

        {
            "Dan Halen",
            "Hank",
            "MyBad",
                         /* RANT: we are supposed to add this with a append method here: PlayerFollowers.Add("Rayman"); 
                           but the book does not show you where. its kinda
                            scuffed */
        };


        Debug.LogFormat("Current Followers: {0}", PlayerFollowers.Count);

        /* note 1: this does update the count
           only if executed after 
            modifying the list */


        PlayerFollowers.Add("Jackie"); // ch.4 (pg.178)

        PlayerFollowers.Remove("Hank");

        PlayerFollowers.Insert(1, "Rayman");




      
        foreach (var partyMember in PlayerFollowers) 
        {
            Debug.LogFormat("{0} - Here!", partyMember);
          
        }


       
    }

    public void HealthStatus()
    {
        while (PlayerHearts > 0)
        {
            Debug.Log("Still Alive!");
            PlayerHearts--; // whats this for again?
        }
        Debug.Log("Player KO'd...");
    }
        
}


