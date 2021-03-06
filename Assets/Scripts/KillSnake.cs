﻿using UnityEngine;
using System.Collections;

// Kills the snake if he collides with poison
public class KillSnake : MonoBehaviour 
{

	GameObject[] snakeBody;
	public AudioClip glass;
	public bool dead;


	IEnumerator OnTriggerEnter(Collider c)
	{
		if (c.gameObject.name == "Snake") {
			audio.PlayOneShot (glass);
			GameObject.Find ("loserMessage").guiText.enabled = true;

			(GameObject.Find ("Snake").GetComponent<Move>()).enabled = false;
			yield return new WaitForSeconds(1);
			GameObject.Find ("_GameManager_").GetComponent<GameManager>().Dead();
			//Destroy (GameObject.Find ("Snake head"));
			Destroy (GameObject.Find ("Snake"));
			snakeBody = GameObject.FindGameObjectsWithTag ("SnakeBody");			
			for (int i = 0; i < snakeBody.Length; i++) {
				Destroy (snakeBody [i]);
			}


		} else {
			yield return new WaitForSeconds(0);
		}
	}
}
