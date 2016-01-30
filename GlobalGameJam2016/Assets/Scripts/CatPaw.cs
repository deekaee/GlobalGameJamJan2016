using UnityEngine;
using System.Collections;

public class CatPaw : MonoBehaviour {
	public int speed;
	public int steps;
	Vector3 direction;
	int count = 0;
	Transform start;
	// Use this for initialization
	void Start () {
		start = this.transform(
	}

	// Update is called once per frame
	void Update () {

		if (count > 0) {
			this.transform.Rotate (direction*steps);
			count--;
		} else 
				{
			this.transform.rotation = start.rotation;

			this.transform.position = start.position;
		}
	}

	public void startHit(Vector3 playerview)
	{
		count = speed;
		direction = playerview;
	}
}
