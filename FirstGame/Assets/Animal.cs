﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Classes are used to classify things, they're used to seperate objects.
//Parantheses are used to tell classes what to do.
//Curly brackets are a box within which the classes exist.
//The conventions and syntax in C# are both used to turn the language of computers
//into English, so that we as humans can speak plainly to get the computer to
//do what we want it to do.

//Ints are smaller and faster to use, floats (floating point values) are more precise
//Strings (string of characters) have to have " " in order to function.
//Data in variables can be changed.
//In games you have functions and parameters (variables).

//There are five kinds of variables; integral, floating point, decimal, boolean, and nullable.
//Integral are just whole numbers.
//Floating points (floats) are more exact, but take more space.
//Decimal types are just decimal numbers.
//Booleans are true or false values.
//Nullables are mutations of other variable types, it just adds the option to return a null value to the values of other variables.
public class Animal : MonoBehaviour {

	public bool Key = false;
	public string Name;
	public int foodCount;
	// Use this for initialization
	void Start () {
		print("My animal is eating.");
		print("Now my animal is sleeping.");
	}
	
	void OnMouseDown()
	{

		print("I have a " + Name);
		print("It has this amount of food left: " + foodCount);

		if(foodCount == 42)
		{
			print ("The pet has found the meaning of life.");
		}

		if(Name == "Cat")
		{
			print ("This creature is the epitome of evil.");
		}

		if (Name == "Dog")
		{
			print ("He's a good boy!");
		}

		if(Key == true)
		{
			print ("Door has been unlocked.");
		}

		if(Key == true)
		{
			print ("The door slides open");
		}

	}

	// Update is called once per frame
	void Update () {
		
	}
}