using UnityEngine;
using System.Collections;

public class RitualCircle : MonoBehaviour {
	private GameObject myObject = null;
	public RitualChecker r;
	public int delay = 400;
	// Use this for initialization
	void Start () {
		UnityEngine.Cursor.visible = true;
		this.GetComponentInChildren<ParticleSystem> ().enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		delay--;
	}
		
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals("RitualObject") && !other.tag.Equals("Player") && !hasObject()&& delay <=0) {
			other.attachedRigidbody.velocity = new Vector3 (0, 0, 0);
			other.attachedRigidbody.isKinematic = true;
			//other.attachedRigidbody.rotation = new Vector3 (0, 0, 0);
			other.gameObject.transform.position =  this.gameObject.transform.position;
			myObject = other.gameObject;
			RitualObjectBehaviour b = other.gameObject.GetComponent<RitualObjectBehaviour> ();
			b.setCircle (this);
			this.GetComponentInChildren<ParticleSystem> ().enableEmission = true;
			// Add particle effects
			delay = 400;

			Debug.Log ("Add Object");
		}
	}

	public bool hasObject()
	{
		return myObject!=null;
	}

	public void removeObject()
	{
		myObject.transform.position = new Vector3 (myObject.transform.position.x + this.GetComponent<SphereCollider> ().radius + 5, myObject.transform.position.y, myObject.transform.position.z);
		myObject.GetComponent<Rigidbody> ().isKinematic = false;
		myObject.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (40, 500, 40));

		this.GetComponentInChildren<ParticleSystem> ().enableEmission = false;
		myObject = null;
		delay = 400;
		Debug.Log ("Removed Object");
	}

}
