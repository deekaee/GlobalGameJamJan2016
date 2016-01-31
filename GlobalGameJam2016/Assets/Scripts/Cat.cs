using UnityEngine;
using System.Collections;

public class Cat : MonoBehaviour {
	public AudioClip hitsound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.gameObject.tag.Equals("Floor"))
		{
			if (hitsound != null)
				AudioSource.PlayClipAtPoint (hitsound, transform.position);
		}

	}
}
