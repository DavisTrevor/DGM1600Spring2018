using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		UnityEngine.ParticleSystem.Emit(100);
	}
	
}
