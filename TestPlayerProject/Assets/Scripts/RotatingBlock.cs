using UnityEngine;
using System.Collections;

public class RotatingBlock : MonoBehaviour {
	private int down = 1;
	public GameObject player;
	private int distanceToPlayer = 6;
	public float fallSpeed = 20.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab)) {
			down = 0;
		}
		if (down == 0) {
			// Slowly rotate the object around its X axis at 1 degree/second.
			transform.Rotate(Vector3.right * Time.deltaTime * fallSpeed);
			
			// ... at the same time as spinning relative to the global 
			// Y axis at the same speed.
			transform.Rotate(Vector3.up * Time.deltaTime * fallSpeed, Space.World);
		}
	}
}
