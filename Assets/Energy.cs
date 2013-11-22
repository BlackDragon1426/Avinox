using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour
{
	[Range(0, 1000)]
	public float power = 1000;

	
	public float rechargeRate = 100;

	void Start()
	{
		power = 1000;
	}
	
	void FixedUpdate()
	{
		if(power >= 0 && power < 1000)
		{
			power += rechargeRate * Time.fixedDeltaTime;
		}
	}
}

