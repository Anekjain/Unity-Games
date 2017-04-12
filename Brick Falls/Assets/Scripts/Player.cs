using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 15f;
	public float mapwidth = 5.6f;
	private Rigidbody2D rb;


	void Start()
	{
		rb = GetComponent<Rigidbody2D> ();

	}

	void FixedUpdate ()
	{
		float x = Input.GetAxis ("Horizontal") * Time.fixedDeltaTime * speed;
		Vector2 newPosition = rb.position + Vector2.right * x;
		newPosition.x = Mathf.Clamp (newPosition.x, -mapwidth, mapwidth);
		rb.MovePosition (newPosition);

	}

	void OnCollisionEnter2D (Collision2D c) {
		FindObjectOfType<GameManager> ().EndGame ();
	}

}
