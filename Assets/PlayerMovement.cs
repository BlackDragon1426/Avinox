using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	float walkSpeed = 3;
	float jogSpeed = 6;
	float sprintSpeed = 10;
	
	float flightSpeed;
	
	bool grounded = false;
	
	public float currentSpeed;
	
	void FixedUpdate ()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		
		if(Input.GetKey(KeyCode.LeftShift))
		{
			currentSpeed = Mathf.Lerp(jogSpeed, sprintSpeed, Time.time / 2f);
		}
		else
		{
			currentSpeed = jogSpeed;
		}
	
		Vector3 direction = new Vector3(h,0.0f,v);
		transform.Translate(direction * currentSpeed * Time.deltaTime);
		
		if(Input.GetKeyDown(KeyCode.Space) && grounded == true)
		{
			rigidbody.AddForce(Vector3.up * 5.0f,ForceMode.VelocityChange);	
		}
		
		
	}
	
	void GroundedCheck()
	{
		
	}
}