using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	private float jump = 375;
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 v3 = new Vector3 (moveHorizontal* 1.5f, moveVertical * 1.5f, 0.0f);
		rb.AddForce (v3);
		if (Input.GetKeyDown (KeyCode.Space)){

			rb.AddForce(new Vector3(0,jump,0));
		}
	}
}
