using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpTrigger : MonoBehaviour {

	public PowerUp MyPowerUp;
	public Player MyPlayer;

	void OnTriggerEnter(Collider other)
	{
		AddPower(MyPowerUp);
	}
	
	void AddPower (PowerUp powerUp)
	{
		print(powerUp.PowerLevel);
		MyPlayer.Health += MyPowerUp.PowerLevel;
	}
}
