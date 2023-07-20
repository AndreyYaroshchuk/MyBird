using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private Birds birds;
    private int score = 0;
    private int levelScore = 2;
    public int Score { get => score; set => score = value; }

    private void Update()
    {
        UpdateScore();
        NextLeveles();
    }
    private void UpdateScore()
    {
        Score = (int)birds.transform.transform.position.x;
    }
    private void NextLeveles()
    {
        if(Score == levelScore)
        {
            levelScore += levelScore;
            birds.Speed += 0.1f;
            if (birds.Speed == 3)
            {
                birds.Rb.gravityScale = 1;
            }
            Debug.Log(birds.Speed);
        }
    }
}
