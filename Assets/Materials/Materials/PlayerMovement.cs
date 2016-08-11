using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	//public float h = 0;
	CharacterController _controller;
	
	[SerializeField]
	 float _moveSpeed = 5.0f;
	[SerializeField]
	 float _jumpSpeed = 20.0f;
	
	 [SerializeField]
	 float _gravity = 1.0f;
	
	GameObject poppy;
	
	 float _yVelocity = 0.0f;
	// Use this for initialization
	void Start () {
		_controller = GetComponent<CharacterController>();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		//h = Input.GetAxis("Horizontal");
		Vector3 direction = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
		Vector3 velocity = direction * _moveSpeed;
		
		if (_controller.isGrounded)
		 {
		 if (Input.GetButtonDown("Jump"))
		 {
		 
		 _yVelocity = _jumpSpeed;
		 
		 }
		 }
		 else
		 {
		 _yVelocity -= _gravity;
		 }
	
		 velocity.y = _yVelocity;
			
			 _controller.Move(velocity * Time.deltaTime);
			
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="Finish"){Debug.Log("ok");}
	}
}
