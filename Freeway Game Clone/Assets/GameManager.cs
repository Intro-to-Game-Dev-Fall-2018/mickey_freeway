using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{

	private float timer;
	private bool timeisGoing;

	// Use this for initialization
	void Start ()
	{
		timer = 76; 
		timeisGoing = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (timeisGoing)
		{
			SetTimer();
		
			if (timer <= 0)
			{
				timer = 0;
				timeisGoing = false;
				SceneManager.LoadScene(SceneManager.GetActiveScene().name);
				
			}
		}

		if(Input.GetKeyDown("2"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name); //restarts the game

		}
	}
	
	void SetTimer() //runs the timer
	{
			timer -= Time.deltaTime; //decreases time
	}
}


