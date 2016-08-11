using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	Texture2D _crosshair;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
	GUI.DrawTexture(new Rect(0, 0, 30, 30), _crosshair);
	}
}
