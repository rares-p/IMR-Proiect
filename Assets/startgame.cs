using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startgame : MonoBehaviour
{
    public string player1Scene = "Player1";
	public string player2Scene = "Player2";


    public void startPlayer1()
    {
        SceneManager.LoadScene(player1Scene);
    }

	public void startPlayer2()
	{
		SceneManager.LoadScene(player2Scene);
	}
}
