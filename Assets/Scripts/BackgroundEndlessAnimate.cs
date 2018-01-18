using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundEndlessAnimate : MonoBehaviour {

	public GameObject[] Backgrounds;
	public float MoveSpeed;
	public GameManager gameManager;

	//0 - 19.2  = - 19.2;
	private float leftBorder = -19.2f;
	//(19.2 * 2) = 38.4
	private float rightBorder = 38.4f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameManager.IsGameOver) {
			//animate background
			Backgrounds[0].transform.position = new Vector3 (Backgrounds[0].transform.position.x - MoveSpeed, 0f,0f);
			Backgrounds[1].transform.position = new Vector3 (Backgrounds[1].transform.position.x - MoveSpeed, 0f,0f);
			Backgrounds[2].transform.position = new Vector3 (Backgrounds[2].transform.position.x - MoveSpeed, 0f,0f);

			//check for border left and assign to right
			foreach(var bg in Backgrounds)
			{
				if (bg.transform.position.x <= leftBorder) {
					bg.transform.position = new Vector3 (rightBorder, 0.0f, 0.0f);
				}
			}
		}

	}

}
