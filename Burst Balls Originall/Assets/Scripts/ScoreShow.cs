using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreShow : MonoBehaviour
{
    [SerializeField]
    private Text topRecord;
    void OnEnable()
    {
       //GetComponent<Text>().text = "Score: " + Gamehelper.textScore;
        //if (PlayerPrefs.GetInt("Score") < Gamehelper.ScoreINT)
        {
           //PlayerPrefs.SetInt("Score", Gamehelper.ScoreINT);
           //topRecord.text = "Top: " + Gamehelper.ScoreINT;
        }
    }
}
