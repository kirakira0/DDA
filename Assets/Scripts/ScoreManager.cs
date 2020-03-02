﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour 
{
    public Text scoreText;
    public Text highScoreText;

    private Agent Agent; 

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

	// Use this for initialization
	void Start () 
	{
        Agent = FindObjectOfType<Agent>();
	    if(PlayerPrefs.HasKey("highScore"))
        {
            highScoreCount = PlayerPrefs.GetFloat("highScore");
        }
	}
	
	// Update is called once per frame
	void Update () 
	{
        Agent.coinsCollected.text = "COINS COLLECTED: " + scoreCount.ToString(); 
        // if (scoreIncreasing)
        // {
        //     scoreCount += pointsPerSecond * Time.deltaTime;
        // }

        // if(scoreCount > highScoreCount)
        // {
        //     highScoreCount = scoreCount;
        //     PlayerPrefs.SetFloat("highScore", highScoreCount);
        // }

        // scoreText.text = "Score: " + Mathf.Round(scoreCount);
        // highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
	}

    public void AddScore(int pointsScored)
    {
        scoreCount += pointsScored;                

    }
}
