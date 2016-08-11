using UnityEngine;
using System.Collections;

public class WinJump : MonoBehaviour {

	// Use this for initialization
	CharacterController _controller;
	
	[SerializeField]
	 float _moveSpeed = 5.0f;
	[SerializeField]
	 float _jumpSpeed = 5.0f;
	
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
		Vector3 direction = new Vector3(0, 0,0);
		Vector3 velocity = direction * _moveSpeed;
		
		if (_controller.isGrounded)
		 {
		 
		 
		 _yVelocity = _jumpSpeed;
		 
		 
		 }
		 else
		 {
		 _yVelocity -= _gravity;
		 }
	
		 velocity.y = _yVelocity;
			
			 _controller.Move(velocity * Time.deltaTime);
			
	}
}
