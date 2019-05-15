using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject losepanel, slowTime;

    void Awake()
    {
        lose = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        lose = true;
        slowTime.SetActive(true);
        losepanel.SetActive(true);
        Appodeal.show(Appodeal.INTERSTITIAL);
    }

}
