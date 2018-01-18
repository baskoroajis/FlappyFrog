using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {
	public GameObject Obstacle;
	public int CountGenerate;
	public float DistanceX;
	public float MaxPosY;
	public float MinPosY;
	// Use this for initialization
	void Start () {
		GenerateObstacle ();
	}

	// Update is called once per frame
	void Update () {
		
	}

	void GenerateObstacle()
	{
		for (int i = 0; i < CountGenerate; i++) {
			GameObject newObstacle =  GameObject.Instantiate (Obstacle) as GameObject;
			float posY =  Random.Range (MinPosY, MaxPosY);
			newObstacle.transform.localPosition = new Vector3 (i * DistanceX, posY, -10.0f);
		}
	}
}
