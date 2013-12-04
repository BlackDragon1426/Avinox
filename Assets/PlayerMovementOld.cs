using UnityEngine;
using System.Collections;

public class PlayerMovementOld : MonoBehaviour
{
	float walkSpeed = 3;
	float jogSpeed = 6;
	float sprintSpeed = 10;
	
	bool sprinting = false;
	bool jumping = false;
	
	float flightSpeed;
	
	bool grounded = false;
	public float distanceFromGround;
	
	public float currentSpeed;
	
	void Update()
	{
		float h = Input.GetAxis("MoveX");
		float v = Input.GetAxis("MoveY");
		
		float sprint = Input.GetAxis("Sprint");
		
		if(sprint == 1)
		{
			sprinting = true;
		}
		else
		{
			sprinting = false;
		}
		
		if(sprinting == true)
		{
			currentSpeed = Mathf.Lerp(jogSpeed, sprintSpeed, Time.time / 2f);
		}
		else
		{
			currentSpeed = jogSpeed;
		}
	
		Vector3 direction = new Vector3(h,0.0f,v);
		transform.Translate(direction * currentSpeed * Time.deltaTime);
		
		float jump = Input.GetAxis("Jump");
		
		if(jump == 1)
		{
			jumping = true;
		}
		else
		{
			jumping = false;
		}
		
		if(jumping == true)
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