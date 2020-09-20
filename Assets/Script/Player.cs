using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private Vector2 targetPos;
	public float Yincrement;
	public float speed;
	public float maxHeight;
	public float minHeight;
	public int health = 3;
	public Text healthDisplay;
	public GameObject gameOver;
	public GameObject gameOverSound;
	public GameObject playerSound;
	
	private void Update () 
	{
		Time.timeScale = 1;
		healthDisplay.text = health.ToString();
		if (health <= 0)
		{
			Instantiate(gameOverSound, transform.position, Quaternion.identity);
			gameOver.SetActive(true);
			Destroy(gameObject);
			Time.timeScale = 0;
		}
		transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Instantiate(playerSound, transform.position, Quaternion.identity);
			targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Instantiate(playerSound, transform.position, Quaternion.identity);
			targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
		}
	}
}
