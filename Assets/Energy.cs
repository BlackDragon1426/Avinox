using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour
{
	float maxPower = 1000;
	float minPower = 0;
	
	public float rechargeRate = 100;
	
	public float power;

	void Start()
	{
		power = maxPower;
	}
	
	void FixedUpdate()
	{
		while(power >= 0 && power < 1001)
		{
			power += rechargeRate * Time.fixedDeltaTime;
			
//			if(power > 1000)
//			{
//				power = 1000;
//			}
		}
	}
}

