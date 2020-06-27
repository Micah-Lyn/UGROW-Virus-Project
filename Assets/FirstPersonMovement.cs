using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    // Reference the character controller
	public CharacterController controller;
	
	public float speed = 12f;
	public float gravity = -9.81f;
	public float jumpHeight = 3f;
	
	public Transform GroundCheck;
	public float GroundDistance = 0.4f;
	public LayerMask GroundMask;
	
	Vector3 velocity;
	bool isGrounded;
	
    // Update is called once per frame
    void Update()
    {
		// Check if the object is on the ground
		isGrounded = Physics.CheckSphere(GroundCheck.position, GroundDistance, GroundMask);
		
		// Reset the velocity when the object is on the ground
		if(isGrounded && velocity.y < 0)
		{
			velocity.y = -2f;
		}
		
		// Initializing the inputs
        float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		
		// Moving in a direction based on where you're facing and what input
		Vector3 move = transform.right * x + transform.forward * z;
		
		controller.Move(move * speed * Time.deltaTime);
		
		// Jumping... somehow
		if(Input.GetButtonDown("Jump") && isGrounded)
		{
			velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
		}
		
		// Allow the player to fall
		velocity.y += gravity * Time.deltaTime;
		
		controller.Move(velocity * Time.deltaTime);
    }
}