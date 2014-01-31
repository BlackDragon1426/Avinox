using UnityEngine;
using System.Collections;

public class Direction : MonoBehaviour
{
	public float rot = 0;

	void FixedUpdate()
	{
		rot = 0;
//
//		if(Input.GetAxis("MoveY") >= 0)
//		{
//			if(Input.GetAxis("MoveX") > 0)
//			{
//				rot = Input.GetAxis("MoveX") * 90;
//			}
//			else if(Input.GetAxis("MoveX") < 0)
//			{
//				rot = Input.GetAxis("MoveX") * 90;
//			}
//		}
//		else if(Input.GetAxis("MoveY") <= 0)
//		{
//			rot = 180;
//
//			if(Input.GetAxis("MoveX") > 0)
//			{
//				rot += Input.GetAxis("MoveX") * -1 * 90;
//			}
//			else if(Input.GetAxis("MoveX") < 0)
//			{
//				rot += Input.GetAxis("MoveX") * -1 * 90;
//			}
//		}

		Vector2 joystickOrigin = new Vector2(0,0);

		Vector2 input = new Vector2(Input.GetAxis("MoveX"),Input.GetAxis("MoveY"));

		Vector2 straight = new Vector2(0,1);



		Debug.Log(rot);
	}
}
