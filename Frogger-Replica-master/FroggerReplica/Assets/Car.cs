using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	public float minSpeed = 8f;
	public float maxSpeed = 10f;

    public static float speed;

	void Start ()
	{
		speed = Random.Range(minSpeed, maxSpeed);
	}

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
        //Debug.Log(speed);
	}

}
