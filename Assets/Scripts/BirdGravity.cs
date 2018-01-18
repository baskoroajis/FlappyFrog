using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdGravity : MonoBehaviour {

	public float Gravity;
	public GameManager gameManager;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (!gameManager.IsGameOver) {
			this.transform.Translate (new Vector3 (0.0f, Gravity, 0.0f));
		}
	}
}
