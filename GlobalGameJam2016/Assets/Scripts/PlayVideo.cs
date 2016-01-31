using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour {

	public MovieTexture myMovie;
	public Texture2D Menu;
	
	void Start()
	{
		myMovie.Play();
		AudioSource.PlayClipAtPoint (myMovie.audioClip, Vector3.zero);
	}

	void OnGUI()
	{
		
		if (!myMovie.isPlaying) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Menu);
		}
		else
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), myMovie);
	}

	void Update()
	{

		if(Input.GetMouseButtonDown(0))
		{
			Application.LoadLevel(1);
		}
	}

}
