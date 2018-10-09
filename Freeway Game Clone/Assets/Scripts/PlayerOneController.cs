using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerOneController : MonoBehaviour
{

	public float speed;
	private float verticalOne;
	public Text playerOneScore;
	private Rigidbody2D player;
	private Vector2 startPositionOne;
	private Vector2 moveOne;
	private int countScoreOne;
	public AudioSource pointSound;
	public AudioSource hitSound;
	
	void Start()
	{

		player = GetComponent<Rigidbody2D>();
		speed = .05f; 
		startPositionOne = gameObject.transform.position;
		countScoreOne = 0;
		playerOneScore.text = countScoreOne.ToString();
		moveOne = new Vector2(0, gameObject.transform.position.y);

	}

	void FixedUpdate()
	{
			playerOneMove();

	}
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Average Speed") ||other.gameObject.CompareTag("Average Neg Speed") ||
		    other.gameObject.CompareTag("Fast Speed") || other.gameObject.CompareTag("Fast Neg Speed") ||
		    other.gameObject.CompareTag("Fastest Speed") || other.gameObject.CompareTag("Fastest Neg Speed"))
		{
			hitSound.Play();
			transform.position = startPositionOne;
			Debug.Log("Hit Enemy");
		}

		if (other.gameObject.CompareTag("Background"))
		{
			pointSound.Play();
			countScoreOne += 1;
			SetCountText();
			transform.position = startPositionOne;
		}
		
	}

	void playerOneMove()
	{
		verticalOne = Input.GetAxis("VerticalOne");
		moveOne = new Vector2(0, verticalOne);
		player.MovePosition(player.position + moveOne * speed);
		
		
	}
	
	void SetCountText()
	{
		playerOneScore.text = countScoreOne.ToString();
		
	}
}
