using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
	public int gameScore;
	GameObject besttext;
	GameObject scoretext;
	public GameObject player;
	public GameObject playergreen;
	public GameObject playerred;
	public GameObject gameplayItems;
	public GameObject menuItems;
	public bool green;
	public GameObject greenObj;
	[SerializeField]
	int best;
	void Update () {
		besttext = GameObject.Find ("best_text");
		best = PlayerPrefs.GetInt ("best");
		if (besttext != null) {
			besttext.GetComponent<Text> ().text = "Best: " + best.ToString ();
		}
		scoretext = GameObject.Find ("score_text");
		if (scoretext != null) {
			scoretext.GetComponent<Text> ().text = "Score: " + gameScore.ToString();
		}}
	public void SwitchColor()
	{	
		green = !green;
		if (green == true){
			greenObj.SetActive(true);
			player = playergreen;
		
		}
		if (green == false){
			greenObj.SetActive(false);
			player = playerred;
		}
	}
	public void EnablePlayer()
	{
		player.SetActive (true);
	}
	public void restart(){
		SceneManager.LoadScene ("game");
	}
}