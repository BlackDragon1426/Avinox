using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	float walkSpeed = 3;
	float jogSpeed = 6;
	float sprintSpeed = 10;
	
	float flightSpeed;
	
	bool grounded = false;
	public float distanceFromGround;
	
	public float currentSpeed;
	
	void FixedUpdate()
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
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GroundedCheck();
			
			if(grounded == true)
			{
				rigidbody.AddForce(Vector3.up * 5.0f,ForceMode.VelocityChange);	
			}
			else if(grounded == false)
			{
				Flight();
			}
		}
		
		 Vector3 down = transform.TransformDirection(Vector3.down * 2);
		Debug.DrawRay (transform.position, down, Color.green);
	}
	
	void GroundedCheck()
	{
		RaycastHit hit;
		Ray downRay = new Ray(transform.localPosition, Vector3.down);
		
		
		if(Physics.Raycast(downRay, out hit))
		{
//			Physics.IgnoreCollision(hit.collider, collider);
			
			distanceFromGround = hit.distance;
			
			if(distanceFromGround < 1.05)
			{
				grounded = true;
			}
			else
			{
				grounded = false;
			}
			Debug.Log(hit.distance - 1);
		}
	}
	
	void Flight()
	{
		Debug.Log ("Flying");
	}
}