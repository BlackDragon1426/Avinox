using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour
{
	float inputSpeed = 5;

	float runningSpeed;
	float sprintingMult = 1;
	float energyBonus;
	float health;

	float SprintAccelMLimit = 2;
	float SprintAccelLLimit = 1;

	bool sprinting = false;
	
	public Energy energyTotal;
	public Health healthTotal;

	void Start ()
	{
		energyTotal = GetComponent<Energy>();
		healthTotal = GetComponent<Health>();
	}


	public void FixedUpdate ()
	{
		health = healthTotal.health / 1000;
		energyBonus = energyTotal.power / 1000 * 3;

		runningSpeed = inputSpeed * sprintingMult * health;
		runningSpeed += energyBonus;

		if(Input.GetKey(KeyCode.LeftShift) && sprintingMult < SprintAccelMLimit)
		{
			sprintingMult += 0.2f * Time.deltaTime;
		}

		else if (sprintingMult > SprintAccelLLimit)
		{
			sprintingMult -= 0.5f * Time.deltaTime;
		}

		Debug.Log(runningSpeed);

	}


}