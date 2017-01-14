﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static bool GameIsOver = false;

    public GameObject gameOverUI;

    void Start()
    {
        GameIsOver = false;
        Time.timeScale = 1f;
    }

	// Update is called once per frame
	void Update () {
        if (GameIsOver)
            return;

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if (PlayerStats.Lives <= 0)
        {
            EndGame();
        }
	}

    void EndGame()
    {
        GameIsOver = true;

        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }
}
