using UnityEngine;
using UnityEngine.UI;

public class playerTwoController : MonoBehaviour
{

	public float speed;
	private float verticalTwo;
	public Text playerTwoScore;
	private Rigidbody2D player2;
	private Vector2 startPositionTwo;
	private Vector2 moveTwo;
	private int countScoreTwo;
	public AudioSource pointSound;
	public AudioSource hitSoundScream;

	// Use this for initialization
	void Start ()
	{
		player2 = GetComponent<Rigidbody2D>();
		speed = .05f;
		startPositionTwo = gameObject.transform.position;
		countScoreTwo = 0;
		playerTwoScore.text = countScoreTwo.ToString();
		moveTwo = new Vector2(0, gameObject.transform.position.y);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		playerTwoMove();
			
	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Slow") ||other.gameObject.CompareTag("Opposite Slow") ||
		    other.gameObject.CompareTag("Fast") || other.gameObject.CompareTag("Opposite Fast") ||
		    other.gameObject.CompareTag("Speedy") || other.gameObject.CompareTag("Opposite Speedy"))
		{
			hitSoundScream.Play();
			transform.position = startPositionTwo;
		}
		
		if (other.gameObject.CompareTag("Background"))
		{
			pointSound.Play();
			countScoreTwo += 1;
			SetCountText();
			transform.position = startPositionTwo;
		}
	}

	void playerTwoMove()
	{
		verticalTwo = Input.GetAxis("VerticalTwo");
		moveTwo = new Vector2(0, verticalTwo);
		player2.MovePosition(player2.position + moveTwo * speed);
	}
	
	void SetCountText()
	{
		playerTwoScore.text = countScoreTwo.ToString();
	}
}
