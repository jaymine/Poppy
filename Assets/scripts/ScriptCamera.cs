using UnityEngine;
using System.Collections;

public class ScriptCamera : MonoBehaviour {
	
	Transform playerPosition;
	float zAxis=0;
	float yAxis=7;
	// Use this for initialization
	void Start () {
	playerPosition=GameObject.Find("player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = playerPosition.position +new Vector3(14, 10,0);
		transform.LookAt(playerPosition);
	
	}
}
