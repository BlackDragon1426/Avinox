using UnityEngine;
using System.Collections;

public class Speed : MonoBehaviour
{
	public float inputSpeed = 5;

	public float runningSpeed;
	float sprintingMult = 1;
	float energyBonus;
	float health;

	float SprintAccelMLimit = 2;
	float SprintAccelLLimit = 1;

	float SprintAccelTime = 5;
	float SprintDecelTime = 2;
	
	public Energy energyTotal;
	public Health healthTotal;

	void Start ()
	{
		energyTotal = GetComponent<Energy>();
		healthTotal = GetComponent<Health>();
	}


	public void Update ()
	{
//		health = healthTotal.health / 1000;
//		energyBonus = energyTotal.power / 1000 * 3;

		runningSpeed = inputSpeed * sprintingMult;
		if(health > 0.5f)
			runningSpeed *= health;
		else
			runningSpeed *= 0.5f;
		runningSpeed += energyBonus;

		if(Input.GetAxis("Sprint") == 1 && sprintingMult < SprintAccelMLimit)
		{
			sprintingMult += Time.deltaTime / SprintAccelTime;
		}

		else if (sprintingMult > SprintAccelLLimit)
		{
			sprintingMult -= Time.deltaTime / SprintDecelTime;
		}
	}
}