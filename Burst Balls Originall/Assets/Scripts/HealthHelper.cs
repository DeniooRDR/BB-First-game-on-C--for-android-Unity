using System.Collections;
using UnityEngine;

public class HealthHelper : MonoBehaviour
{
    public int MaxHealth = 100;
    public int Health = 100;
    public int Score = 1;
    
    Gamehelper gameHelper;

    void Start()
    {
        gameHelper = GameObject.FindObjectOfType<Gamehelper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetHit(int damage)
    {
        int health = Health - damage;

        if (health <=0)
        {
            gameHelper.ScoreINT += Score;
            Destroy(gameObject);
        }

        Health = health;
    }
}
