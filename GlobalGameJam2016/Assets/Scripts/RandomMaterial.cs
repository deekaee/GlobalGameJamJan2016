using UnityEngine;
using System.Collections;

public class RandomMaterial : MonoBehaviour {
	public Material[] materials;
	// Use this for initialization
	void Start () {
		int index = Random.Range (0, materials.Length);
		GetComponent<Renderer>().material = materials [index];
	}

	// Update is called once per frame
	void Update () {

	}
}

