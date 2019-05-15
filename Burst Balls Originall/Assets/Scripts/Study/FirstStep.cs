using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof (BallsUP))]
[RequireComponent(typeof(HealthHelper))]
public class FirstStep : MonoBehaviour
{    
    private bool firstStep;

    void Start()
    {
        GetComponent<BallsUP>().SpeedUp = 0f;
        Invoke("BallsUp", 1f);
    }

    
    void Update()
    {
        if (transform.position.y < -2.0f && !firstStep)
            firstStep = true;
        GetComponent<BallsUP>().SpeedUp = 2f;
        
    }

    void BallsUp ()
    {
        GetComponent<BallsUP>().SpeedUp = 3;
    }

}
