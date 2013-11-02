using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour
{
	float maxEnergy = 1000;
	float minEnergy = 0;
	
	float energy;

	void Start()
	{
		energy = maxEnergy;
	}
	
	void FixedUpdate()
	{
		
	}
}

