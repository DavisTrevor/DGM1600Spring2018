using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour {

public string AddMember;
public TheIncredibles TheIncredibles;


	// Use this for initialization
	void Start () {
		TheIncredibles.FamilyList.Add(AddMember);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
