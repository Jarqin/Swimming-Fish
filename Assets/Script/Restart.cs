﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour 
{
	public GameObject notification;
	public GameObject gameOver;

	private void Update () 
	{
		Time.timeScale = 0;
		if (Input.GetKeyDown(KeyCode.R))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			Time.timeScale = 1;
		}
		else if (Input.GetKeyDown(KeyCode.Q))
		{
			notification.SetActive(true);
			gameOver.SetActive(false);
		}
		else if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);	
		}
	}
}
