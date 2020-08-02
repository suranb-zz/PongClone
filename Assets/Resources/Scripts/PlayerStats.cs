using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Text player1;
    public Text player2;
    private int player1Score;
    private int player2Score;
    void Start()
    {

        player1Score = PlayerPrefs.GetInt("player1");
        player2Score = PlayerPrefs.GetInt("player2");

        if (player1Score > player2Score)
        {
            player1.text = "WINNER: " + player1Score.ToString();
            player2.text = player2Score.ToString();
        }
        else if (player2Score > player1Score)
        {
            player2.text = "WINNER: " + player2Score.ToString();
            player1.text = player1Score.ToString();
        }
    }
}
