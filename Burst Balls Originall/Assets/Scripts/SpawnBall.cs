using System.Collections;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ball, ball_2, ball_3, ball_bonus, ball_4;
    public static int countBalls = 0;

    
    void Start()
    {
        StartCoroutine(Spawn ());        
    }

    IEnumerator Spawn()
    {
        while (!Player.lose)
        {
            Instantiate(ball, new Vector2 (Random.Range (-2.0f, 2.0f), -6.5f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            countBalls++;

            Instantiate(ball_2, new Vector2(Random.Range(-2.0f, 2.0f), -6.5f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            countBalls++;

            Instantiate(ball_3, new Vector2(Random.Range(-2.0f, 2.0f), -6.5f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            countBalls++;

            Instantiate(ball_bonus, new Vector2(Random.Range(-2.0f, 2.0f), -6.5f), Quaternion.identity);
            yield return new WaitForSeconds(1f);
            countBalls++;

            Instantiate(ball_4, new Vector2(Random.Range(-2.0f, 2.0f), -6.5f), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            countBalls++;
        }

    }

}
