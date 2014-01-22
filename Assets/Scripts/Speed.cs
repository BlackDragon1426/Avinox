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

	bool sprinting = true;
	
	public Energy energyTotal;
	public Health healthTotal;

	void Start ()
	{
		energyTotal = GetComponent<Energy>();
		healthTotal = GetComponent<Health>();
	}


	public void Update ()
	{
		health = healthTotal.health / 1000;
		energyBonus = energyTotal.power / 1000 * 3;

		runningSpeed = inputSpeed * sprintingMult;
		if(health > 0.5f)
			runningSpeed *= health;
		else
			runningSpeed *= 0.5f;
		runningSpeed += energyBonus;

		if(Input.GetKey(KeyCode.LeftShift) && sprintingMult < SprintAccelMLimit || sprinting == true && sprintingMult < SprintAccelMLimit)
		{
			sprintingMult += Time.deltaTime / 5;
		}

		else if (sprintingMult > SprintAccelLLimit)
		{
			sprintingMult -= Time.deltaTime / 2;
		}



		Debug.Log(runningSpeed);

	}


}