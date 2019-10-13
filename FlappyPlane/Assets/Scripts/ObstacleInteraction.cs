using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInteraction : MonoBehaviour {


	public float moveSpeed;
	public GameObject manager;
	int score;
	void Start() {
		AddScore ();
	}
	void Update () {
		manager = GameObject.Find ("GameManager");
		transform.Translate (moveSpeed*Time.deltaTime, 0, 0);
		if (transform.position.x < -4.7f) {
				Destroy (gameObject);
		}		

		}
	void AddScore(){
	if (transform.position.x < 0f) {
		manager.GetComponent<ScoreManager>().gameScore = manager.GetComponent<ScoreManager>().gameScore + 1;
	}
		Invoke ("AddScore",1);
}
}
