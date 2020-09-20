﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notification : MonoBehaviour
{
	public GameObject notification;
	public GameObject gameOver;
	
    public void Yes()
	{
		Debug.Log("QUIT!");
		Application.Quit();	
	}

	public void No()
	{
		notification.SetActive(false);
		gameOver.SetActive(true);
	} 
}
