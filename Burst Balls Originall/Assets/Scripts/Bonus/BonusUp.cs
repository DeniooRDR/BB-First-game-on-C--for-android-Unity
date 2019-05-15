using UnityEngine;

public class BonusUp : MonoBehaviour
{

    void OnMouseDown()
    {
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + Random.Range(5, 10));
    }

}
