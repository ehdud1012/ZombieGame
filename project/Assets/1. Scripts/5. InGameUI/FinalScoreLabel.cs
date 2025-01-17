using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreLabel : MonoBehaviour
{
    Text finalscoreLabel;
    void Start()
    {
        finalscoreLabel = GetComponent<Text>();
    }

    void Update()
    {
        float currentScore = Enemy.DamageScore;
        float bestScore = PlayerPrefs.GetFloat("BestScore", 0); 

        if (currentScore > bestScore)
        {
            finalscoreLabel.text = "Best Score : " + currentScore;
            PlayerPrefs.SetFloat("BestScore", currentScore);
        }
        else
        {
            finalscoreLabel.text = "" + currentScore;
        }
    }
}
