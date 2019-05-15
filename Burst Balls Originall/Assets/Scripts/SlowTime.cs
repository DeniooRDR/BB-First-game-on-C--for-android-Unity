using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SlowTime : MonoBehaviour
{
    private Text CountSlow;
    //public Sprite active, inactive;

    void Start()
    {
        CountSlow = gameObject.transform.GetChild(0).transform.GetComponent<Text>();
        if (!PlayerPrefs.HasKey("SlowTime"))
        {
            PlayerPrefs.SetInt("SlowTime", 2);
            CountSlow.text = "2";
        }
        else
            CountSlow.text = PlayerPrefs.GetInt("Slow Time").ToString();
        //if (PlayerPrefs.GetInt("Slow Time") == 0)
            //GetComponent<Image>().sprite = inactive;
        //else
            //GetComponent<Image>().sprite = active;
    }
    void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("SlowTime") > 0 && Time.timeScale != 0.5f)
        {
            PlayerPrefs.SetInt("SlowTime", PlayerPrefs.GetInt("SlowTime") - 1);
            CountSlow.text = PlayerPrefs.GetInt("SlowTime").ToString();
            //if (PlayerPrefs.GetInt("Slow Time") == 0)
                //GetComponent<Image>().sprite = inactive;
            StartCoroutine(slow());
        }
    }

    IEnumerator slow()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(3f);
        Time.timeScale = 1f;
    }

    void OnDisable()
    {
        Time.timeScale = 1f;
    }
}
