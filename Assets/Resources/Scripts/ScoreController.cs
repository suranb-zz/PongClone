﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{

    private int scorePlayer1 = 0;
    private int scorePlayer2 = 0;

    public GameObject scoreTextPlayer1;
    public GameObject scoreTextPlayer2;

    public GameObject Player1ParticleScore;
    public GameObject Player2ParticleScore;


    public int goalToWin;

    void Update()
    {
        if (this.scorePlayer1 >= this.goalToWin || this.scorePlayer2 >= this.goalToWin)
        {
            // Load GameOver Scene
            SceneManager.LoadScene(2);
        }
    }

    private void FixedUpdate()
    {
        Text uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<Text>();
        uiScorePlayer1.text = this.scorePlayer1.ToString();

        Text uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.scorePlayer2.ToString();
    }

    public void GoalPlayer1()
    {

        Player1ParticleScore.GetComponent<ParticleSystem>().Play();

        //GameObject dashP = Instantiate(dashParticle, transform.position, Quaternion.Euler(0, -90, 0));
        //dashP.GetComponent<ParticleSystem>().Play();
        this.scorePlayer1++;

    }

    public void GoalPlayer2()
    {
        Player2ParticleScore.GetComponent<ParticleSystem>().Play();
        this.scorePlayer2++;
    }
}