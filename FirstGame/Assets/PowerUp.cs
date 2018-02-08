using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class PowerUp : ScriptableObject {

	public int PowerLevel = 100;
	public string Name = "Health";
	public Player CurrentPlayer;

	public void RunPowerUp()
	{
		CurrentPlayer.Score += PowerLevel;
		//Adds Value
		Debug.Log(PowerLevel);
	}
}
