using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

	private float timer;
	private bool timeisGoing;
	public bool pause;
	public Text countdown;
	public AudioSource background;

	// Use this for initialization
	void Start ()
	{
		timer = 60; 
		timeisGoing = true;
		pause = false;
		countdown.text = timer.ToString("f0");
		background.Play();
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

		if(Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name); //restarts the game

		}

		if (Input.GetKeyDown(KeyCode.P))
		{
			pause = !pause;
			if (pause)
			{
				Time.timeScale = 0;
				background.Pause();
			}else if (!pause)
			{
				Time.timeScale = 1;
				background.Play();
			}
		}
		
	}
	
	void SetTimer() //runs the timer
	{
		timer -= Time.deltaTime; //decreases time
		countdown.text = timer.ToString("f0"); //prints the timer
	}

	
}
