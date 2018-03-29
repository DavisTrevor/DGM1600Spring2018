using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
	
	public MovePattern MovePattern;
	private CharacterController controller;

	void Start () 
	{
		controller = GetComponent<ChatacterController>();
	}
	
	void Update () 
	{
		MovePattern.Move(controller, transform);
	}
}
