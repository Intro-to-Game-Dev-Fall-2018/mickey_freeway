
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoController : MonoBehaviour
{

	public float speed;
	private float verticalTwo;
	public Text playerTwoScore;
	private Rigidbody2D player2;
	private Vector2 startPositionTwo;
	private Vector2 moveTwo;
	private int countScoreTwo;
	public AudioSource pointSound;
	public AudioSource hitSound;

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
		if (other.gameObject.CompareTag("Average Speed") ||other.gameObject.CompareTag("Average Neg Speed") ||
		other.gameObject.CompareTag("Fast Speed") || other.gameObject.CompareTag("Fast Neg Speed") ||
		    other.gameObject.CompareTag("Fastest Speed") || other.gameObject.CompareTag("Fastest Neg Speed"))
		{
			hitSound.Play();
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
		player2.MovePosition(position: player2.position + moveTwo * speed);
	}
	
	void SetCountText()
	{
		playerTwoScore.text = countScoreTwo.ToString();
	}
}

