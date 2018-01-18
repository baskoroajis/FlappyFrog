using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour {
	public GameManager GameManager;
	public float JumpValue;

	private const float JUMPTIMEVAL = 8f;
	private bool isJump = false;
	private float jumpTime;
	// Use this for initialization
	void Start () {
		jumpTime = JUMPTIMEVAL;
	}

	void OnMouseDown(){
		if (!GameManager.IsGameOver) {
			isJump = true;
		}
	}

	// Update is called once per frame
	void Update () {
		if (!GameManager.IsGameOver) {
			if (isJump && jumpTime >= 0.0f) {
				GameManager.Bird.transform.Translate (new Vector3 (0.0f, JumpValue, 0.0f));
				jumpTime--;
			} else {
				isJump = false;
				jumpTime = JUMPTIMEVAL;
			}
		}


	}
}
