using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SelectLocation : MonoBehaviour
{
    public Sprite thisOne, notOne;
    public GameObject[] notLocation;

    [SerializeField]
    private string nameOfLocation;

    void Start()
    {
        if (!PlayerPrefs.HasKey("Location"))
            PlayerPrefs.SetString("Location", "Suburb");
        if (PlayerPrefs.GetString("Location") == nameOfLocation)
        {
            gameObject.transform.GetChild(0).transform.GetComponent<Image>().sprite = thisOne;
        }
        else
        {
            gameObject.transform.GetChild(0).transform.GetComponent<Image>().sprite = notOne;
        }

    }

    void OnMouseUpAsButton()
    {
        PlayerPrefs.SetString("Location", nameOfLocation);
        for (int i = 0; i < notLocation.Length; i++)
            notLocation[i].GetComponent<Image>().sprite = notOne;        
        gameObject.transform.GetChild(0).GetComponent<Image>().sprite = thisOne;
    }
}
