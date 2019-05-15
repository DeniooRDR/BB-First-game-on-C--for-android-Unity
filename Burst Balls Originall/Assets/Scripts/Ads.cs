using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;

public class Ads : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {        
        string appKey = "3aca0d979122ac176c57992ab7e176c20036e9ea3063ffdd";
        Appodeal.initialize(appKey, Appodeal.INTERSTITIAL | Appodeal.NON_SKIPPABLE_VIDEO);
    }

}
