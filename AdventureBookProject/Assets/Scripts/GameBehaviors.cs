
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using CustomInt = System.Int64; //end of ch 10 pg. 489 //PURPOSE:if we wanted to create a type alias to refer to the existing Int64 type,

using UnityEngine.SceneManagement;

using CustomExtensions;
public class GameBehaviors : MonoBehaviour, IManager
{
    public Stack<Loot> LootStack = new Stack<Loot>();

    public CustomInt PlayerHealth = 100; //near end of ch 10
    private string _state;
    
    public string State
    {
        get { return _state; }
        set { _state = value; }


    } //end of function S:I



    // public const int MaxItemsA = 4; //ch 10

    // public readonly int MaxItemsB;

    public void UpdateScene(string updatedText)
    {
        ProgressText.text = updatedText;
        Time.timeScale = 0f;
    } //end of function >:D




    private int _itemsCollected = 0;
    
    public int Items
    {
        get { return _itemsCollected; }

        set
        {
            _itemsCollected = value;       

            ItemText.text = "Items: " + Items;

            if (_itemsCollected >= MaxItems)
            {
                WinButton.gameObject.SetActive(true);
                
                UpdateScene("You've found all the items!");

                

                Time.timeScale = 0f;
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) +
                " more to go!";
            }
        }
    }//end of function >:D

    public int MaxItems = 4; //change how many items needed to win, also in inspector for GameManager object

    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;

        Initialize();

    } //end of function >:D

    



    // Update is called once per frame
    void Update()
    {




    }//end of function >:D


    



    
    public Button WinButton;

    public Button LossButton;

    private int _playerHP = 1; // change player health value here!

    public int HP
    {
        get { return _playerHP; }
        set
        {
            _playerHP = value;
            HealthText.text = "Health: " + HP;
            if(_playerHP <= 0)
            {

                LossButton.gameObject.SetActive(true);
                //3
                UpdateScene("You want another life with that?");
                
               
            }
            else
            {
                ProgressText.text = "Ouch... that's got hurt.";
            }
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    } //end of function >:D

    public void RestartScene()
    {
       Utilities.RestartLevel(0);
        
    } //end of function >:D

    public void Initialize()
    {

        _state = "Game Manager initialized..";
        Debug.Log(_state);

        _state.FancyDebug();
        Debug.Log(_state);

        LootStack.Push(new Loot("Sword of Doom", 5));
        LootStack.Push(new Loot("HP Boost", 1));
        LootStack.Push(new Loot("Golden Key", 3));
        LootStack.Push(new Loot("Pair of Winged Boots", 2));
        LootStack.Push(new Loot("Mythril Bracer", 4));

        FilterLoot();

    } //end of function >:D
    

    public void PrintLootReport()
    {
        
        var currentItem = LootStack.Pop();
        var nextItem = LootStack.Peek();
        Debug.LogFormat("You got a {0}! You've got a good chance of finding a {1} next!", currentItem.Name, nextItem.Name);
        Debug.LogFormat("There are {0} random loot items waiting for you!", LootStack.Count);

    }//end of function >:D

    public void FilterLoot()
    {
        var rareLoot = (from item in LootStack //Ch11 <--- this is the rareLoot query here!
        where item.Rarity >= 3
        orderby item.Rarity   
        select new { item.Name })
        .Skip(1);
        foreach (var item in rareLoot)
        {
            Debug.LogFormat("Rare item: {0}!", item.Name);
        }


    }//end of function >:D

    public bool LootPredicate(Loot loot)
    {
        return loot.Rarity >= 3;


    } //end of function >:D
}
