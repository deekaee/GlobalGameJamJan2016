﻿using UnityEngine;
using System.Collections;

public class RitualChecker : MonoBehaviour {
	public RitualCircle[] RitualCircles;
	public GameObject Good;
	public GameObject Bad;
	// Use this for initialization
	void Start () {
		Good.GetComponent<ParticleEmitter> ().emit = false;
		Bad.GetComponent<ParticleEmitter> ().emit = false;
	}
	
	// Update is called once per frame
	void Update () {
		CheckRitual ();
	}

	public void CheckRitual()
	{
		foreach (RitualCircle r in RitualCircles) {
			if (r.hasObject()) {
				//Do All the things
			}
		}
	}
}
