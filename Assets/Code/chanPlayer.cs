using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


	public class chanPlayer : MonoBehaviour {
	public float speed  ;
	public float moveSpeed = 5f;
	public Text scoreText;
	public CharacterController player;

	private Vector3 movement;
	private Animator anim;
	private bool jumping = false;
	private bool isdead;
	private float scores;





	// Use this for initialization
	void Start () {
		

		if (speed == 0)
			speed = 5f;
		
		player = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
	}
	void FixedUpdate(){
		scores += 1;
		scoreText.text = scores.ToString ();
	}
	void Update(){

		movement = Vector3.zero;
		movement.z = 1 * speed * Time.deltaTime;
		movement.x = Input.GetAxis ("Horizontal") * Time.deltaTime * moveSpeed;
		if (player.isGrounded) {
			movement.y = 0f;	
		} else {
			if(!jumping)
			movement.y -= 9.8f * Time.deltaTime;
		}


		if (Input.GetKeyDown (KeyCode.Space)) {
			anim.SetTrigger ("jump");
			changeCenter ();
		}
		player.Move (movement);
	}

	void changeCenter(){
		jumping = true;
		player.center = new Vector3 (player.center.x, 1.94f, player.center.z);
	}

	public void DefaultChan(){
		jumping = false;
		player.center = new Vector3 (player.center.x, 0.73f, player.center.z);
	
	}

	void OnControllerColliderHit(ControllerColliderHit hit){

			if (hit.transform.tag == "hurdle" && !isdead) {
			isdead = true;

			anim.SetTrigger ("death");
			}
	}


	public void RestartGame(){
		Application.LoadLevel (Application.loadedLevelName);
	}




}

	//anim.SetTrigger ("death");