using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

//Using UnityEngine.UI
//Image var FillAmount
//if(FillAmount > 0 subtract health.)
//PowerUp Class Float PowerLevel

public Image FillAmount;
public PowerUp PowerLevel;

	void Start () {
	OnCollision;
		if (FillAmount > 0)
		{
			FillAmount - PowerLevel;
		}
	
	}
	

}
