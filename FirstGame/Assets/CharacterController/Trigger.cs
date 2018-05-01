using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	public float PowerLevel;
	public Image HealthBar;
	public PowerUp PowerUpTransfer;
	
	private void OnTriggerEnter(Collider obj)
	{
		obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.MovePattern;
		gameObject.SetActive(false);
		HealthBar.FillAmount += PowerLevel;
		if(HealthBar.FillAmount = 0)
		{
			obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.MovePattern;
		}
	}
}
