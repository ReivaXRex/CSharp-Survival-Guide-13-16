using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDifficulty : MonoBehaviour
{
    // public int easy, normal, hard, currentLevelSelected;

    public enum LevelSelector
    {   
        Easy, // 0          Easy = 0
        Normal, // 1        Normal = 56;
        Hard, // 2          Hard = 45;
        Expert // 3         Expert  = 23;
    }

    public LevelSelector currentLevel;

    void Start()
    {
        switch (currentLevel)
        {
            case LevelSelector.Easy:
                Debug.Log("You Selected Easy!");
                break;
            case LevelSelector.Normal:
                Debug.Log("You Selected Normal!");
                break;
            case LevelSelector.Hard:
                Debug.Log("You Selected Hard!");
                break;
            case LevelSelector.Expert:
                Debug.Log("You Selected Expert!");
                break;
            default:
                Debug.Log("Invalid difficulty selected");
                break;

        }
    }
}
