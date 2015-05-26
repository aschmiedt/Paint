using UnityEngine;
using System.Collections;

public class FallingBlock : MonoBehaviour {
	// Use this for initialization
	private int down = 1;
	public GameObject player;
	private int distanceToPlayer = 6;
	public float fallSpeed = 8.0f;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, player.transform.position)<distanceToPlayer) {
			down = 0;
		}
		if (down == 0) {
			print(Time.deltaTime);
			transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
		}
	}
}
