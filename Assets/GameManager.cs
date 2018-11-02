using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static bool gameIsOver;

    public GameObject gameOverUI;


    private void Start()
    {
        gameIsOver = false;
    }

    void Update () {
        
        if (gameIsOver)
        {
            return;
        }

        //REMOVE THIS BEFORE SHIP
        /*
        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }
        */

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        gameIsOver = true;

        gameOverUI.SetActive(true);
    }

}
