using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	float speed = 10;
	
	void Start ()
	{
	}
	
	void FixedUpdate ()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
	
		Vector3 direction = new Vector3(h,0.0f,v);
		transform.Translate(direction * speed * Time.deltaTime);
		
		if(Input.GetKeyDown(KeyCode.Space))
		{
			rigidbody.AddForce(Vector3.up * 5.0f,ForceMode.VelocityChange);	
		}
		
	}
}