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

    public string TheseCanOnlyHoldTheirAssignedType = "mono"; //  i am using Pascal case for this long variable name

    void Start()

    {
        
        int characterLevel = 32;
        int nextSkillLevel = GenerateCharacter("stinky",characterLevel);
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

    }

    // Update is called once per frame

    /// <summary>
    /// The secret sauce
    /// </summary>
    /// 

    public void MethodName() //ch.3 code
    {
        Debug.LogFormat("Text goes here, add {0} and {1} as variable " +
            "placeholders", CurrentAge, FirstName);
    }
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
    void Update()
    {
        

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
}
