using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {

	public string[] Names;

	// Use this for initialization
	void Start () {
		
		for (int i = 0; i < Names.Length; i++)
		{
			print(Names[i]);
		}

		foreach (var Name in Names)
		{
			print(Name);
		}
	}
	

}
