﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {
	public int A;
	public int B;
	public int C;

	// Use this for initialization
	void Start () {
		if (A + B == C)
		{
			print (C);
		}

		if (C - A == B)
		{
			print(B);
		}

		if (A * B == C)
		{
			print (C);
		}

		if (A <= 0)
		{
			A++;
		}

		if (A >= 10)
		{
			A--;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}