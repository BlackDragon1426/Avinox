using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	float currentSpeed = 0;
	
	float idle = 0;
	float walking = 0;
	float running = 0;
	float sprinting = 0;
	
	float slideBoost = 0;
	float flightBoost = 0;

	void Start ()
	{

	}

	void Update ()
	{
		float x = Input.GetAxis("MoveX") * currentSpeed;
		float z = Input.GetAxis ("MoveY") * currentSpeed;

		constantForce.force = Vector3.up * z;


	}
}