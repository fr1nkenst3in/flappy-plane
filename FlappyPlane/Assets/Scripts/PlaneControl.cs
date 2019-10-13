using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneControl : MonoBehaviour {

	Rigidbody2D rb;
	public Vector2 velocitynew;
	public float jumpHeight;
	Vector3 rotnormal;
	int lastbestscore;
	public float rotSpeed;
	GameObject collidedObj;
	GameObject manager;
	public Quaternion normalRot;
	void Update () {
		transform.Rotate(0,0,rotSpeed*Time.deltaTime);
		manager = GameObject.Find ("GameManager");
		lastbestscore = PlayerPrefs.GetInt ("best");
		if (transform.position.y < -4.7f) {
			SceneManager.LoadScene ("game");
		}
		if (transform.position.y > 4.7f) {
			SceneManager.LoadScene ("game");
		}
		if (lastbestscore < manager.GetComponent<ScoreManager> ().gameScore) {
			PlayerPrefs.SetInt ("best", manager.GetComponent<ScoreManager> ().gameScore);
		}
	}
	void OnCollisionEnter2D (Collision2D col)
	{
		manager = GameObject.Find ("GameManager");
		collidedObj = col.gameObject;
		lastbestscore = PlayerPrefs.GetInt ("best");
		if (collidedObj.tag == "Obstacle") {
			SceneManager.LoadScene ("game");
		}
	}
	public void jump () {
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(0f, jumpHeight);
		transform.localRotation = normalRot;
	}

}
	