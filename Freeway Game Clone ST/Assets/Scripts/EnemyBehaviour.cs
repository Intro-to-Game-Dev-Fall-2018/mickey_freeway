using UnityEngine;

//this should be on the enemy prefab

public class EnemyBehaviour : MonoBehaviour
{
	private float enemySpeed;
	private Vector2 restartLeft;
	private Vector2 restartRight;
	 private void Start ()
	{

		SpeedChange(); 
		restartLeft = new Vector2(-10.83f, gameObject.transform.position.y);
		restartRight = new Vector2(10.83f, gameObject.transform.position.y);

	} 

	private void Update()
	{
		
		transform.Translate(enemySpeed, 0, 0);
		

	}


	private void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag("Right Boundary")) //hits gameObject off screen that triggers the reset
		{
			gameObject.transform.position = restartLeft;
			Debug.Log("Enemy has reset position");
		}else if (other.gameObject.CompareTag("Left Boundary"))
		{
			gameObject.transform.position = restartRight;
			Debug.Log("Enemy has reset position");
		}
	}

	void SpeedChange()
	{

		if (gameObject.CompareTag("Average Speed"))
		{
			enemySpeed = .05f;
		}else if (gameObject.CompareTag("Average Neg Speed"))
		{
			enemySpeed = -.05f;
		}

		if (gameObject.CompareTag("Fast Speed"))
		{
			enemySpeed = .08f;
		}else if (gameObject.CompareTag("Fast Neg Speed"))
		{
			enemySpeed = -.08f;
		}

		if (gameObject.CompareTag("Fastest Speed"))
		{
			enemySpeed = .095f;
		}else if (gameObject.CompareTag("Fastest Neg Speed"))
		{
			enemySpeed = -.095f;
		}
		
	}

}
