using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Gamehelper : MonoBehaviour
{
    public int ScoreINT;    
    public Text textScore;
    public Text FinalScore;
    public Text TopRecord;


    void Start()
    {
        ScoreINT = 0;        
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = ScoreINT.ToString();
        
        FinalScore.text = "Score: " + ScoreINT.ToString();

        if (PlayerPrefs.GetInt("Score") < ScoreINT)
        {
            PlayerPrefs.SetInt("Score", ScoreINT);
            TopRecord.text = "Top: " + ScoreINT.ToString();
        }
        else
        {
            TopRecord.text = "Top: " + PlayerPrefs.GetInt("Score").ToString();
        }
          
        
    }

}
