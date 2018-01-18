using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject Bird;
	public GameObject GameOver;
	public bool IsGameOver;
	private bool isGameOverAdded;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (IsGameOver) {
			if (!isGameOverAdded) {
				GameObject.Instantiate (GameOver);
				isGameOverAdded = true;
			}
		}
	}


}
