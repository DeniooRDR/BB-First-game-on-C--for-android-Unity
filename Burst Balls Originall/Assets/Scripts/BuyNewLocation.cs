using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class BuyNewLocation : MonoBehaviour
{
    public GameObject[] buttonsToDisable;
    public GameObject[] notLocation;
    public GameObject check;
    public Sprite uncheked, chekedSprite;
    public Text coins;
    [SerializeField]
    private int price;
    [SerializeField]
    private string nameOfLocation;


    void Awake()
    {
        if (PlayerPrefs.GetString(nameOfLocation) == "Open")
        {
            for (int i = 0; i < buttonsToDisable.Length; i++)
                buttonsToDisable[i].SetActive(false);
            check.SetActive(true);
        }
    }
    void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("Coins") >= price)
        {
            PlayerPrefs.SetString("Location", nameOfLocation);
            PlayerPrefs.SetString(nameOfLocation, "Open");
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - price);
            coins.text = PlayerPrefs.GetInt("Coins").ToString();
            for (int i = 0; i < buttonsToDisable.Length; i++)
                buttonsToDisable[i].SetActive(false);
            for (int i = 0; i < notLocation.Length; i++)
                notLocation[i].GetComponent<Image>().sprite = uncheked;
            check.SetActive(true);
            check.transform.GetChild(0).GetComponent<Image>().sprite = chekedSprite;
        }
    }
}
