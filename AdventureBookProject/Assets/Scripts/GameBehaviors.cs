using UnityEngine;
using TMPro;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameBehaviors : MonoBehaviour, IManager
{

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

    public int MaxItems = 4;

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

    } //end of function >:D


}
