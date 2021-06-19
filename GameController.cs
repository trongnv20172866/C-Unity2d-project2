using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Obstacle;
    public float spawnTime;
    float m_spawnTime;
    bool m_isGameover;
    int m_score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_spawnTime -= Time.deltaTime;
        if(m_spawnTime <= 0)
        {
            SpawnObstacle();
            m_spawnTime = spawnTime;
        }
    }
    public void SpawnObstacle()
    {
        float randYpos = Random.Range(-2.75f, -1f);
        Vector2 spawnPos = new Vector2(15, randYpos);
        if(Obstacle)
        {
            Instantiate(Obstacle, spawnPos, Quaternion.identity);
        }

    }

    public void SetScore(int value)
    {
        m_score = value;
    }

    public int GetScore()
    {
        return m_score;
    }
    public void ScoreIncrement()
    {
        m_score++;
    }
    public bool IsGameOver()
    {
        return m_isGameover;
    }
    public void SetGameoverState(bool state)
    {
        m_isGameover = state;
    }
}
