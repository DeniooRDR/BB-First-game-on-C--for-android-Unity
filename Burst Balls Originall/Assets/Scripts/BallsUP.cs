using UnityEngine;

public class BallsUP : MonoBehaviour
{
    [SerializeField]
    public float SpeedUp = 5f;       
    public static int countBomb;

    void Start()
    {
        countBomb = 0;
    }
    void Update()
    {
        transform.position += new Vector3(0, SpeedUp * Time.deltaTime, 0);
    }

    void OnMouseDown()
    {
        if (!Player.lose)
        {            
            GetComponent<HealthHelper>().GetHit(100);
            countBomb++;            
        }
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt ("Coins") +5);
        
    }

}
