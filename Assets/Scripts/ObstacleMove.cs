using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour {

	public float MoveSpeed;
	private const float LEFTBORDER = -19.2f;
	private const float RIGHTBORDER = 38.4f;
	private GameManager gameManager;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find ("GameManager").GetComponent<GameManager> ();
	}

	// Update is called once per frame
	void Update () {
		if (!gameManager.IsGameOver) {
			transform.Translate( new Vector3 ((MoveSpeed * -1),0f,0f));

			if (transform.localPosition.x <= LEFTBORDER)
				transform.localPosition = new Vector3 (RIGHTBORDER,transform.localPosition.y,-10.0f);
			
		}

	}
}
