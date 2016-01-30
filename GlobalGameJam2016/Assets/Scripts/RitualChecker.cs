using UnityEngine;
using System.Collections;

public class RitualChecker : MonoBehaviour {
	public RitualCircle[] RitualCircles;
	public GameObject Good;
	public GameObject Bad;
	// Use this for initialization
	void Start () {
		Good.GetComponentInChildren<ParticleSystem> ().enableEmission = false;
		Bad.GetComponentInChildren<ParticleSystem> ().enableEmission = false;
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


				///
			
			}

			//accessing first shape
			if (RitualCircles [0].hasObject ()) {
				//if there is somethng in circle 1
				if (RitualCircles [0].getObject ().GetComponent<RitualObjectBehaviour> ().shape == RitualObjectBehaviour.type.Circle)
 {					//If that object is of type circle
				}
			}
		}
	}
}
