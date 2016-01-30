using UnityEngine;
using System.Collections;

public class RitualObjectBehaviour : MonoBehaviour {
	public string name;
	private RitualCircle circle  = null;
	int count = 0;
	Vector3 player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		count--;
		if (count == 1) {
			if (circle != null)
				circle.removeObject ();
			this.gameObject.GetComponent<Rigidbody> ().AddExplosionForce (250, player, 3);

		}
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
			p.GetComponentInChildren<CatPaw>().startHit (v);
			Debug.Log ("VECTOR" + (v*100).ToString ());
			StartHitDelay (v, 5);
			}
	}

	void StartHitDelay(Vector3 p, int delay)
	{
		player = p;
		count = delay;
	}
}
