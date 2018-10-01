using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class PlayerOneController : MonoBehaviour
{

	public float speed;
	public Text playerOneScore;
	private Rigidbody2D player;
	private Vector2 startPositionOne;
	private Vector2 moveOne;
	private int countScoreOne;
	
	void Start()
	{

		player = GetComponent<Rigidbody2D>();
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
			transform.position = startPositionOne;
			Debug.Log("Hit Enemy");
		}

		if (other.gameObject.CompareTag("Background"))
		{
			countScoreOne += 1;
			SetCountText();
			transform.position = startPositionOne;
		}
		
	}

	void playerOneMove()
	{
		float verticalOne = Input.GetAxis("VerticalOne");
		moveOne = new Vector2(0, verticalOne);
//		player.AddForce(moveOne * speed);
		player.MovePosition(player.position + moveOne * Time.fixedDeltaTime);
		
		
	}
	
	void SetCountText()
	{
		playerOneScore.text = countScoreOne.ToString();
		if (countScoreOne >= 5)
		{
			Time.timeScale = 0;
		}
	}
}
