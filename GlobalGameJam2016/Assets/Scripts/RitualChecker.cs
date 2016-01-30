using UnityEngine;
using System.Collections;

public class RitualChecker : MonoBehaviour {
	public RitualCircle[] RitualCircles;
	// Use this for initialization
	void Start () {
	
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
