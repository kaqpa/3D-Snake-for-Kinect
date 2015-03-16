using UnityEngine;
using System.Collections;

public class ChangeRightTexture : MonoBehaviour {
	Texture samePlane;
	Texture back;
	Texture front;
	GameObject snake;


	// Use this for initialization
	void Start () {
		snake = GameObject.FindGameObjectWithTag ("Snake");
		if (snake.transform.position.x == this.transform.position.x) {
			this.renderer.material.mainTexture = samePlane;
				}
		if (snake.transform.position.x < this.transform.position.x) {
			this.renderer.material.mainTexture = back;
		}
		if (snake.transform.position.x > this.transform.position.x) {
			this.renderer.material.mainTexture = front;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		snake = GameObject.FindGameObjectWithTag ("Snake");
		if (snake.transform.position.x == this.transform.position.x) {
			this.renderer.material.mainTexture = samePlane;
		}
		if (snake.transform.position.x < this.transform.position.x) {
			this.renderer.material.mainTexture = back;
		}
		if (snake.transform.position.x > this.transform.position.x) {
			this.renderer.material.mainTexture = front;
		}
	}
}
