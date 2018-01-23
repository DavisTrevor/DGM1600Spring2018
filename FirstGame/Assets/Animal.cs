using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classes are used to classify things, they're used to seperate objects.
//Parantheses are used to tell classes what to do.
//Curly brackets are a box within which the classes exist.
//The conventions and syntax in C# are both used to turn the language of computers
//into English, so that we as humans can speak plainly to get the computer to
//do what we want it to do.

public class Animal : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("My animal is eating.");
		print("Now my animal is sleeping.");
	}
	
	void OnMouseDown()
	{
		print("Meow.");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
