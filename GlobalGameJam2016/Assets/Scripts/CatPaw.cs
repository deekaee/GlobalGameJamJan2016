using UnityEngine;
using System.Collections;

public class CatPaw : MonoBehaviour {
	public int speed;
	public int steps;
	Vector3 direction;
	int count = 0;
	//Transform start;
	// Use this for initialization
	void Start () {
		//start.position = this.transform.position;
		//start = this.GetComponentInParent<Transform>()
	}

	// Update is called once per frame
	void Update () {

		//if (count > 0) {
		//	this.transform.Rotate (direction*steps);
		//	count--;
		//} else 
		//		{
		//	this.transform.rotation = this.transform.parent.gameObject.transform.parent.gameObject.transform.rotation;
			//this.transform.position = start.position;
		//}
	
	}

	public void startHit(Vector3 playerview)
	{
		count = speed;
		direction = playerview;
	}
}
