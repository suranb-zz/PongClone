using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("END GAME");
            Restart();
        }
    }

    void Restart()
    {
        //TODO
        // restart the Scene unless if we wnat to use the GUI 
    }
}
