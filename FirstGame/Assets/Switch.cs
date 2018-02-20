using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string UserName;

	// Use this for initialization
	void Start () {
		switch (UserName)
		{
			case "Password":
				print("Password is correct.");
				//Do Work
				break;
			
			case "LevelUp":
				print ("Ding!");
				//Do Work
				break;
			
			case "BlackPanther":
				print ("Made all of the money.");
				break;

			default:
				print("Why don't you just tell me which movie you want to see");
				//Do Work
			break;

		}
	}
	
}
