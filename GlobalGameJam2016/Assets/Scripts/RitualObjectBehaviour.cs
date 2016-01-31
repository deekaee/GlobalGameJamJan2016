using UnityEngine;
using System.Collections;

public class RitualObjectBehaviour : MonoBehaviour {
	public string IDname;
	public enum type {Circle, Eye, Rectangle, Broom, Crescent, None};
	public type shape;
	private RitualCircle circle  = null;
	int count = 0;
	Vector3 player;
	GameObject g;
	// Use this for initialization
	void Start () {
		g = GameObject.FindGameObjectWithTag ("Canvas").transform.GetChild(0).gameObject;
		g.SetActive (false);

		Debug.Log (g);
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
		;
		//calculate distance for cursor size
		RectTransform t = g.GetComponentInChildren<RectTransform>();
		//Vector3 currentScale = new Vector3 (t.localScale.x, t.localScale.y, t.localScale.z);
		float distance = Vector3.Distance (this.gameObject.transform.position, GameObject.FindGameObjectWithTag ("Player").transform.position);
		float maxDistance = 2f;
		//float distance = 0;
		//float b = Mathf.InverseLerp (maxDistance, 1, distance/maxDistance);

		//t.localScale = new Vector3 (b,b,b)*6;
		//RaycastHit hit;
		//GameObject p2 = GameObject.FindGameObjectWithTag ("Player");

		//Vector3 v1 = p2.transform.position;
		//GameObject c = GameObject.FindGameObjectWithTag ("MainCamera");
		//Camera c1 = c.GetComponent <Camera> ();
		//Ray r1 = c1.ScreenPointToRay (new Vector3 (c1.pixelWidth, c1.pixelHeight, 0 ));
		//Ray r = new Ray (v1,v1 - transform.position);
		//Debug.DrawRay (r.origin, r.direction);

		//if (Physics.Raycast (r, out hit, 10000 )) {
		//	Debug.Log ("HIT");
			//if (hit.collider.gameObject.GetComponentInParent<RitualObjectBehaviour>() != null)
		//			distance = hit.distance;
		//	Debug.Log (distance);
		//}
		float b = Mathf.InverseLerp (maxDistance, 1, distance/maxDistance);
		//if (distance < 0)
		//	b = 0;
		//if (distance > maxDistance)
		//	b = 0;
		t.localScale = new Vector3 (b,b,b)*6;

		if (g != null && distance > maxDistance)
			g.SetActive (true);

		//if clicking on the item
		if(Input.GetMouseButtonDown(0) && distance > maxDistance)
			{
				GameObject p = GameObject.FindGameObjectWithTag ("Player");

			Vector3 v = p.transform.position;
				p.GetComponentInChildren<CatPaw> ().startHit (v);
				Debug.Log ("VECTOR" + (v * 100).ToString ());
				StartHitDelay (v, 5);
			}
		if (Input.GetMouseButtonDown (1)) {
			this.GetComponent<Rigidbody> ().velocity = Vector3.zero;
		}
	}

	void  OnMouseExit()
	{
		if (g!=null)
			g.SetActive (false);
	}

	void StartHitDelay(Vector3 p, int delay)
	{
		if (circle != null) {
			circle.removeObject ();
			this.leaveCircle ();
		}
		this.gameObject.GetComponent<Rigidbody> ().AddExplosionForce (1000, p, 3);

	}
}
