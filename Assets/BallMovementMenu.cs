﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementMenu : MonoBehaviour
{

    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    public int hitCounter = 0;


    // Use this for initialization
    void Start()
    {
        StartCoroutine(this.StartBall());
    }


    void PositionBall(bool isStartingPlayer1)
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        if (isStartingPlayer1)
        {
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);
        }

    }


    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {

        this.PositionBall(isStartingPlayer1);

        this.hitCounter = 0;
        yield return new WaitForSeconds(0);


        if (isStartingPlayer1)
            this.MoveBall(new Vector2(-1, 0));
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }

    }

    public void MoveBall(Vector2 dir)
    {

        dir = dir.normalized;

        float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

        Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();

        rigidBody2D.velocity = dir * speed;
    }


    public void IncreaseHitCounter()
    {
        if (this.hitCounter * this.extraSpeedPerHit <= this.maxExtraSpeed)
        {
            this.hitCounter++;
            // TODO 
            // Add fire tail particle when maybe
        }
    }
}
