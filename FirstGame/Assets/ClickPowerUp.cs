using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerUp : MonoBehaviour {

	public PowerUp MyPowerUp;
	private void OnMouseDown()
	{
		if(MyPowerUp.PowerLevel >= 100)
		{
			print ("I have the power.");
		}

		if(MyPowerUp.Name == "Health")
		{
			print ("Feelin' Healthy.");
		}
	}
}
