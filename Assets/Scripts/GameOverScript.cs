﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		SceneManager.LoadScene (0);
		GameObject.Find ("GameManager").GetComponent<GameManager> ().IsGameOver = false;
	}
}

