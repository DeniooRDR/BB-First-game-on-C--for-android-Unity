using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class BuySlowTime : MonoBehaviour
{
    public Text count, coins;
    void Start()
    {
        count.text = PlayerPrefs.GetInt("SlowTime").ToString();
    }

    void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("Coins") >= 1500)
        {
            PlayerPrefs.SetInt("SlowTime", PlayerPrefs.GetInt("SlowTime") + 1);
            count.text = PlayerPrefs.GetInt("SlowTime").ToString();
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 1500);
            coins.text = PlayerPrefs.GetInt("Coins").ToString();
        }
    }
}
