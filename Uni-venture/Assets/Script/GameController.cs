﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text scoreLabel;
    public GameObject GameClearLabel;
    public GameObject unityChan;
    public GameObject gameOverText;
    public GameObject Text;
    private bool gameOver = false;
	
	void Update () {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreLabel.text = count.ToString();

        if (count == 0)
        {
            GameClearLabel.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                Application.LoadLevel("title");
            }
        }
        if (gameOver)
        {
            gameOverText.SetActive(true);
            Text.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                Application.LoadLevel("title");
            }
            if (Input.GetKey(KeyCode.R))
            {
                Application.LoadLevel("stage01");
            }
        }
	}

    public void GameOver ()
    {
        gameOver = true;
        Destroy(unityChan);
    }
}
