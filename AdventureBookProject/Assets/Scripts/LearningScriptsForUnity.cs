using UnityEngine;

public class LearningScriptsForUnity : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int CurrentAge = 30;
    public int AddedAge = 1;
    void Start()

    { 
        Debug.Log(30 + 1); Debug.Log(CurrentAge + 1);

        ComputeAge();
    }

    // Update is called once per frame

    /// <summary>
    /// The secret sauce
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + AddedAge);
    }
    void Update()
    {
        

    }
}
