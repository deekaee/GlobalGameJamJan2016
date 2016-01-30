using UnityEngine;
using System.Collections;

public class BatAtThings : MonoBehaviour {
	public Vector3 force;
	// Use this for initialization
	void Start () {
		UnityEngine.Cursor.visible = true;
		Debug.logger.Log ("ARRRRRGGGG");
	}
	
	// Update is called once per frame
	void Update () {
	

	}
	void OnMouseClick (){
		Debug.logger.Log("In Mouse Down");
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 100)) {
			Debug.logger.Log ("In Hit");
			if (hit.transform.gameObject.tag.Equals ("RitualObject")){
				hit.transform.gameObject.GetComponent<Rigidbody>().AddForce (force);
			}
		}
}
}
