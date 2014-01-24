using UnityEngine;
using System.Collections;

public class Direction : MonoBehaviour
{
	public float rot = 0;

	void FixedUpdate()
	{
		rot = 0;

		if(Input.GetAxis("MoveY") >= 0)
		{
			if(Input.GetAxis("MoveX") > 0)
			{
				rot = Input.GetAxis("MoveX") * 90;
			}
			else if(Input.GetAxis("MoveX") < 0)
			{
				rot = Input.GetAxis("MoveX") * 90;
			}
		}
		else if(Input.GetAxis("MoveY") <= 0)
		{
			rot = 180;

			if(Input.GetAxis("MoveX") > 0)
			{
				rot += Input.GetAxis("MoveX") * -1 * 90;
			}
			else if(Input.GetAxis("MoveX") < 0)
			{
				rot += Input.GetAxis("MoveX") * -1 * 90;
			}
		}
		Debug.Log(rot);
	}
}
