using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	
	public Rigidbody rb;

	public float speed = 50f;
	public float turnSpeed = 3f;

	void FixedUpdate ()
	{
		
		rb.AddForce(0, 0, speed * Time.deltaTime);

		if (Input.GetKey("d"))
		{
			rb.AddForce(turnSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey("a")) 
		{
			rb.AddForce(-turnSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
