using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logic : MonoBehaviour {
	//Operators can change the order of operations.
	//Everything has to happen in a function.
	//
	
	public int A;
	public int B;
	public string Password;
	public int Heart;
	public int Health;

	// Use this for initialization
	void Start () {
		if (A == B)
		{
			print ("True.");
		}
		
		if (A > B)
		{
			print ("Greater.");
		}

		if (A < B)
		{
			print ("Lesser");
		}

		if (A != B)
		{
			print ("Not Equal.");
		}

		if (Password == "love" || Password == "Love" || Password == "LOVE")
		{
			Heart = 100;
			Health += 10;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
