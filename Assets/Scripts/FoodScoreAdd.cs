﻿using UnityEngine;
using System.Collections;

public class FoodScoreAdd : MonoBehaviour {
	static GameObject ob;
	static GameManager sc;
	public int score;
	public int level;
	// Use this for initialization
	void Start () {
		ob = GameObject.Find("_GameManager_");
		sc = (GameManager)ob.GetComponent(typeof(GameManager));
	}
	
	// Update is called once per frame
	void OnDestroy () {
		sc.AddPoints ();

		score = GameObject.Find ("_GameManager_").GetComponent<GameManager> ().LastScore();
		print ("eaten food, score " + score);
		if (score % 5 == 0 && !GameObject.Find ("_GameManager_").GetComponent<GameManager> ().death) {
			GameObject.Find ("_GameManager_").GetComponent<GameManager>().Winning();
		

		
		//uspesne ukonceny level - had zjedol 5 potrav




			print("won the level");
			if(GameObject.Find ("_GameManager_").GetComponent<GameManager> ().currentLevel == 10)
			{
				print("won the game");
				Application.LoadLevel("WinningGame");
			}
			else
			{
			Application.LoadLevel("WinningScreen");
			//GameObject.Find ("_GameManager_").GetComponent<GameManager> ().TakeOffPointsAddedAfterSnakeDead (3+level/2);
			print("winning screen loaded");
			}
		}
	}
}
