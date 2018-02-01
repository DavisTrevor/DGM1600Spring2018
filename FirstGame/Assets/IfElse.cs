using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour {


	public bool Key;
	public int Health = 100;
	public string Password = "OU812";
	// Use this for initialization
	void Start () {
		
	}
	
	void OnMouseDown()
	{
		if (Key == true)
		{
			print("I have the key.");
		}
		else
		{
			print("The Way is closed.");
		}

		if (Health > 0)
		{
			print("Can play.");
		}
		else
		{
			print("You're dead!");
		}
		
		if (Password == "OU812")
		{
			print("That is correct.");
		}
		else
		{
			print("Try again.");
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
