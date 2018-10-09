using UnityEngine;

//this should be on the enemy prefab

public class Enemy : MonoBehaviour
{
    private float enemySpeed;
    private Vector2 restartLeft;
    private Vector2 restartRight;
    private void Start ()
    {

        SpeedChange(); 
        restartLeft = new Vector2(-9.221f, gameObject.transform.position.y);
        restartRight = new Vector2(9.221f, gameObject.transform.position.y);

    } 

    private void FixedUpdate()
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

        if (gameObject.CompareTag("Slow"))
        {
            enemySpeed = .03f;
        }else if (gameObject.CompareTag("Opposite Slow"))
        {
            enemySpeed = -.03f;
        }

        if (gameObject.CompareTag("Fast"))
        {
            enemySpeed = .05f;
        }else if (gameObject.CompareTag("Opposite Fast"))
        {
            enemySpeed = -.05f;
        }

        if (gameObject.CompareTag("Speedy"))
        {
            enemySpeed = .07f;
        }else if (gameObject.CompareTag("Opposite Speedy"))
        {
            enemySpeed = -.07f;
        }
		
    }

}
