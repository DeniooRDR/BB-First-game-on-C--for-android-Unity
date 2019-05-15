using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLocation : MonoBehaviour
{
    public GameObject[] locations;

    void Start()
    {
        if (PlayerPrefs.HasKey("Location"))
        {
            for (int i = 0; i < locations.Length; i++)
            {
                if (PlayerPrefs.GetString("Location") == locations[i].name)
                    locations[i].SetActive(true);
                break;
            }
        }
        else        
            locations[0].SetActive(true);        
    }


}
