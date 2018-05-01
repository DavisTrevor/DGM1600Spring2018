using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticles : MonoBehaviour {

	private void private void OnTriggerEnter(Collider other)
	{
		ParticleSystem.Emit(100);
	}
	
}
