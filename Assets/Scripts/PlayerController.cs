using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour {

	// Use this for initialization

	public Vector2 jumpForce =  new Vector2(0,200);
	//Animator anim;
	int score=0;
	public Text scoreText;
	public GameObject GameoverObject;

	void Start () {
		//anim= gameObject.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("space") || Input.touchCount==1)
		{	
			//anim.SetTrigger("jump");
			//anim.SetBool("iswalk", false);
			GetComponent<Rigidbody2D>().AddForce(jumpForce);	
			//anim.SetBool("isjump", false);
		}

	}

	void OnTriggerEnter2D(Collider2D col)
	{
		
		if(col.gameObject.CompareTag("Collectable"))
		{
			//print("Collision detected with a trigger object");
			scoreText.text="Score: "+ (++score);
			print(score);
			Destroy(col.gameObject);

		}

		else if(col.gameObject.CompareTag("Enemy"))
		{
			Debug.Log ("Game Over");
			GameoverObject.SetActive(true);
			gameObject.SetActive(false);
		}
	
		}

	public void reset(){
		SceneManager.LoadScene("main",LoadSceneMode.Single);
	}
}
