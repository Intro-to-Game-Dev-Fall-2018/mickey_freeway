using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		 //this only alters the chickens, not the enemies so what will alter the enemies? 
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown("2"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);

		}
		
		if (Input.GetKeyDown("1"))
		{
			//SceneManager.LoadScene(SceneManager.nextsceneeventually, won't always be a set scene);
		}
		
	}
}


