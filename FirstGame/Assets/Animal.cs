using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
