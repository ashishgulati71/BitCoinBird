using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectableMovement : MonoBehaviour {

	// Use this for initialization.


	public Vector2 speed = new Vector2(-4.0f, 0);


	void Start () {
		GetComponent<Rigidbody2D>().velocity=speed;	

		float height = Random.Range(-3,4);
		transform.position = new Vector3 (transform.position.x, height , transform.position.z);
	}


}
