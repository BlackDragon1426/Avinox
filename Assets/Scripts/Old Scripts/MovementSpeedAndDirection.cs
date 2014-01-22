using UnityEngine;
using System.Collections;

public class MovementSpeedAndDirection : MonoBehaviour
{
	public class Speeds
	{
		public float sprintingMult;

		public void Update(float sMult)
		{
			sprintingMult = sMult;
			float energyTotal = 1;
			float energyBonus = 3 * energyTotal;
			float runningSpeed = 6 + energyBonus * sprintingMult;
		}
	}

	public class Direction
	{
		float x = Input.GetAxis ("MoveX");
		float z = Input.GetAxis ("MoveY");

		void Update()
		{
			Vector3 inputDirection = new Vector3 (x, 0, z);
			Vector3 directionMovement = inputDirection;
		}
	}

	public Speeds sprintingMultiplyer = new Speeds();

	void Update()
	{
		float sMult = Mathf.Lerp(1f, 2f, Time.time / 5f);

		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			Debug.Log (sprintingMultiplyer.sprintingMult);
			sprintingMultiplyer.Update(sMult);

		}
		Debug.Log (sprintingMultiplyer.sprintingMult);

	}
}
