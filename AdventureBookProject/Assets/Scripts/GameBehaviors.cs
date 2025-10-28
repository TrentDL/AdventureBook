using UnityEngine;
using TMPro;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class GameBehaviors : MonoBehaviour
{




    public int MaxItems = 4;

    public TMP_Text HealthText;
    public TMP_Text ItemText;
    public TMP_Text ProgressText;



    public Button WinButton;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ItemText.text += _itemsCollected;
        HealthText.text += _playerHP;


    }
    private int _itemsCollected = 0;



    // Update is called once per frame
    void Update()
    {




    }


    public int Items
    {
        get { return _itemsCollected; }

        set
        {
            _itemsCollected = value;
            Debug.LogFormat("Items: {0}", _itemsCollected);

            ItemText.text = "Items: " + Items;

            if (_itemsCollected >= MaxItems)
            {
                ProgressText.text = "You've found all the items!";

                WinButton.gameObject.SetActive(true);

                Time.timeScale = 0f;
            }
            else
            {
                ProgressText.text = "Item found, only " + (MaxItems - _itemsCollected) +
                " more!";
            }
        }
    }//end of function >:D

    private int _playerHP = 10;

    public int HP
    {
        get { return _playerHP; }

        set
        {
            _playerHP = value;
            HealthText.text = "Health: " + HP;
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    } //end of function >:D

    public void RestartScene()
    {
        SceneManager.LoadScene(0);

        Time.timeScale = 1f;
        
    } //end of function >:D

}
