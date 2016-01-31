﻿using UnityEngine;
using System.Collections;

public class RitualChecker : MonoBehaviour {
	public RitualCircle[] RitualCircles;
	public GameObject Good;
	public GameObject Bad;
	int count = 0;
	// Use this for initialization
	void Start () {
		Good.GetComponentInChildren<ParticleSystem> ().enableEmission = false;
		Bad.GetComponentInChildren<ParticleSystem> ().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		CheckRitual ();

		//Turn off ritual
		if (count > 1) {
			count--;
		}
		if (count == 1) {
			Good.GetComponentInChildren<ParticleSystem> ().enableEmission = false;
			Bad.GetComponentInChildren<ParticleSystem> ().enableEmission = false;
			count--;
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			StartRitual();
		}
	}

	public void CheckRitual()
	{
		foreach (RitualCircle r in RitualCircles) {
			if (r.hasObject()) {
				//Do All the things


				///
			
			}
			bool[] vals = { false, false, false, false, false };
			//accessing first shape
			for (int i = 0; i < 5; i++) {
				if (RitualCircles [i].hasObject ()) {
					//if there is the right type in it 1
					if (RitualCircles [i].getObject ().GetComponent<RitualObjectBehaviour> ().shape == RitualCircles [i].type) {
						vals [i] = true;
					}
				}
			}
			if (vals[0] && vals[1] && vals[2] && vals[3] && vals[4])
			{
				///RITUAL
				StartRitual();
			}
		}
	}

	void StartRitual()
	{
		Good.GetComponentInChildren<ParticleSystem>().enableEmission = true;
		count = 400;
	}

}
