using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour {

	public MovieTexture myMovie;
	public Texture2D Menu;
	
	void Start()
	{
		myMovie.Play();
	}

	void OnGUI()
	{
		
		if (!myMovie.isPlaying) {
			GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Menu);
		}
		else
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), myMovie);
	}
}
