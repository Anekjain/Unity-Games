using UnityEngine;

public class Block : MonoBehaviour {

	public float gravitySpeed = 20f; 

	void Start () {
		GetComponent<Rigidbody2D> ().gravityScale += Time.timeSinceLevelLoad / gravitySpeed;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y <= -6.5) {
			Destroy (gameObject);
		}
	}
}
