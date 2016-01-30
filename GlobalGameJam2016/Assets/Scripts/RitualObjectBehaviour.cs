using UnityEngine;
using System.Collections;

public class RitualObjectBehaviour : MonoBehaviour {
	public string name;
	private RitualCircle circle  = null;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setCircle(RitualCircle r)
	{
		circle = r;
	}

	public void leaveCircle()
	{
		circle = null;
	}

	public bool hasCircle()
	{
		return circle != null;
	}

	public RitualCircle getCircle()
	{
		return circle;
	}

	void OnMouseOver (){
		if(Input.GetMouseButtonDown(0))
			{
			GameObject p = GameObject.FindGameObjectWithTag ("Player");
			Vector3 v = p.transform.forward;
			Debug.Log ("VECTOR" + (v*100).ToString ());
			this.gameObject.GetComponent<Rigidbody> ().AddExplosionForce (1000, p.transform.position, 5);
			}
	}

}
