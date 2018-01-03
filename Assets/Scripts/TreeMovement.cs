using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMovement : MonoBehaviour {
	
	public Vector2 speed = new Vector2(-4.0f, 0);
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity=speed;	
		//GetComponent<BoxCollider2D>();
		float Width = Random.Range(0f,0.5f);
	
		transform.localScale= new Vector3(0.4f+Width,Width+0.6f,0);
		transform.position = new Vector3 (transform.position.x, -3.8f , transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
