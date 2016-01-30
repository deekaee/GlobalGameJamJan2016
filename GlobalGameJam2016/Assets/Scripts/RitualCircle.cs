using UnityEngine;
using System.Collections;

public class RitualCircle : MonoBehaviour {
	private GameObject myObject = null;
	public RitualChecker r;
	// Use this for initialization
	void Start () {
		UnityEngine.Cursor.visible = true;
		this.GetComponent<ParticleEmitter> ().emit = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals("RitualObject") && !other.tag.Equals("Player") && !hasObject()) {
			other.attachedRigidbody.velocity = new Vector3 (0, 0, 0);
			other.attachedRigidbody.isKinematic = true;
			//other.attachedRigidbody.rotation = new Vector3 (0, 0, 0);
			other.gameObject.transform.position =  this.gameObject.transform.position;
			myObject = other.gameObject;
			RitualObjectBehaviour b = other.gameObject.GetComponent<RitualObjectBehaviour> ();
			b.setCircle (this);
			this.GetComponent<ParticleEmitter> ().emit = true;
			// Add particle effects



		}
	}

	public bool hasObject()
	{
		return myObject!=null;
	}

	public void removeObject()
	{
		myObject = null;
		myObject.GetComponent<Rigidbody> ().isKinematic = true;
		this.GetComponent<ParticleEmitter> ().emit = false;
	}

}
