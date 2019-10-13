using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
	public GameObject obstacle;
	Vector3 spawnPos;
	float randomHeight;
	Quaternion spawnRot;
	void Start () {
		Invoke ("spawnObstacle", 1);
	}
	void spawnObstacle () {
		randomHeight = Random.Range(-2.0f,2.0f);
		spawnPos.Set (5.0f, randomHeight, 0);
		Instantiate (obstacle,spawnPos,spawnRot);
		Invoke ("spawnObstacle", 2);
	}
}
