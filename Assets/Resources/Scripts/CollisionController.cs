using System;
using UnityEngine;

public class CollisionController : MonoBehaviour
{

    public BallMovement ballMovement;
    public ScoreController scoreController;
    public GameObject particleHitPlayer;
    public GameObject particleHitWalls;
    public GameObject dashParticle;
    public AudioSource flyBy;
    public AudioSource spree;
    public ParticleSystem particleBall;


    void Awake()
    {
        particleBall.Stop();
    }

    void BounceFromRacket(Collision2D c)
    {

        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Player1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            this.BounceFromRacket(collision);
            GameObject firework = Instantiate(particleHitPlayer, transform.position, Quaternion.identity);
            firework.GetComponent<ParticleSystem>().Play();


            if (ballMovement.hitCounter > 18)
            {

                dashEffect(collision.gameObject.name);
                particleBall.Play();
                flyBy.Play();
            }
            else
            {
                particleBall.Stop();
            }
        }


        else if (collision.gameObject.name == "WallLeft")
        {
            spree.Play();
            scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovement.StartBall(true));
        }
        else if (collision.gameObject.name == "WallRight")
        {
            spree.Play();
            scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovement.StartBall(false));
        }
    }

    private void dashEffect(String playerName)
    {
        if (playerName == "Player1")
        {
            GameObject dashP = Instantiate(dashParticle, transform.position, Quaternion.Euler(0, -90, 0));
            dashP.GetComponent<ParticleSystem>().Play();
        }
        else
        {
            GameObject dashP = Instantiate(dashParticle, transform.position, Quaternion.Euler(0, 90, 0));
            dashP.GetComponent<ParticleSystem>().Play();
        }
    }
}
