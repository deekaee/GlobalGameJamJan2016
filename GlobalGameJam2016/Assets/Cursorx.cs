using UnityEngine;
using System.Collections;

public class Cursorx : MonoBehaviour {
	public Texture2D cursorTexture;
	public CursorMode cursorMode = CursorMode.Auto;
	public Vector2 hotSpot = Vector2.zero;
//	CursorLockMode wantedMode;

	void Start () {

	Cursor.visible = true;
			
	}

	void OnMouseEnter() {
		print ("mouse-enter");
		Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
	}
	void OnMouseExit() {
		print ("mouse-exit");
		Cursor.SetCursor(null, Vector2.zero, cursorMode);
	}

	// Apply requested cursor state
//	void SetCursorState ()
//	{
//		Cursor.visible = true;
//		Cursor.
	//	Cursor.lockState = wantedMode;
		// Hide cursor when locking
		// Cursor.visible = (CursorLockMode.Locked != wantedMode);
//	}

//	void OnGUI ()
//	{
//		GUILayout.BeginVertical ();
//		// Release cursor on escape keypress
//		if (Input.GetKeyDown (KeyCode.Escape))
//			Cursor.lockState = wantedMode = CursorLockMode.None;
//
//		switch (Cursor.lockState)
//		{
//		case CursorLockMode.None:
//			GUILayout.Label ("Cursor is normal");
//			if (GUILayout.Button ("Lock cursor"))
//				wantedMode = CursorLockMode.Locked;
//			if (GUILayout.Button ("Confine cursor"))
//				wantedMode = CursorLockMode.Confined;
//			break;
//		case CursorLockMode.Confined:
//			GUILayout.Label ("Cursor is confined");
//			if (GUILayout.Button ("Lock cursor"))
//				wantedMode = CursorLockMode.Locked;
//			if (GUILayout.Button ("Release cursor"))
//				wantedMode = CursorLockMode.None;
//			break;
//		case CursorLockMode.Locked:
//			GUILayout.Label ("Cursor is locked");
//			if (GUILayout.Button ("Unlock cursor"))
//				wantedMode = CursorLockMode.None;
//			if (GUILayout.Button ("Confine cursor"))
//				wantedMode = CursorLockMode.Confined;
//			break;
//		}
//
//		GUILayout.EndVertical ();

//	}
	}