using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;


public class Buttons : MonoBehaviour
{
    public Sprite button, pressed;
    public bool music;

    private Image img;
    private float yPos;
    private Transform child;

    void Start()
    {
        //PlayerPrefs.DeleteAll();
        Appodeal.show(Appodeal.NON_SKIPPABLE_VIDEO);
        img = GetComponent<Image>();
        child = transform.GetChild(0).transform;

        if (music)
        {
            if (PlayerPrefs.GetString("Music") != "no")
            { // Музыка сейчас играет и мы можем её выключить
                transform.GetChild(0).gameObject.SetActive(true);
                transform.GetChild(1).gameObject.SetActive(false);
            }
            else
            {
                transform.GetChild(0).gameObject.SetActive(false);
                transform.GetChild(1).gameObject.SetActive(true);
                child = transform.GetChild(1).transform;
            }
        }
    }

    void OnMouseDown()
    {
        img.sprite = pressed;
        yPos = child.localPosition.y;
        child.localPosition = new Vector3(child.localPosition.x, 0, child.localPosition.z);
    }

    void OnMouseUp()
    {
        img.sprite = button;
        child.localPosition = new Vector3(child.localPosition.x, yPos, child.localPosition.z);
    }

    void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Music") != "no")
            GetComponent<AudioSource>().Play();
        switch (gameObject.name)
        {
            case "Play":                
                StartCoroutine(loadScene("game"));
                break;
            case "Replay":
               StartCoroutine(loadScene("game"));
                break;
            case "Home":
                Appodeal.show(Appodeal.INTERSTITIAL);
                StartCoroutine(loadScene("MainMenu"));
                break;
            case "Home1":
                Appodeal.show(Appodeal.INTERSTITIAL);
                StartCoroutine(loadScene("MainMenu"));
                break;
            case "How To":
                StartCoroutine(loadScene("study"));
                break;
            case "Replay1":
                StartCoroutine(loadScene("study"));
                break;
            case "Shop":
               StartCoroutine(loadScene("Shop"));
                break;
            case "Close":
                Appodeal.show(Appodeal.INTERSTITIAL);
                StartCoroutine(loadScene("MainMenu"));
               break;
            case "Music":
                child.gameObject.SetActive(false);
                if (PlayerPrefs.GetString("Music") != "no")
                { // Музыка сейчас играет и мы можем её выключить
                    PlayerPrefs.SetString("Music", "no");
                    child = transform.GetChild(1).transform;
                }
                else
                {
                    PlayerPrefs.DeleteKey("Music");
                    child = transform.GetChild(0).transform;
                }
                child.gameObject.SetActive(true);
                break;
        }
    }

    IEnumerator loadScene(string scene)
    {
        float fadeTime = Camera.main.GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
        SceneManager.LoadScene(scene);
    }
}
