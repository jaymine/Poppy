using UnityEngine;
using System.Collections;

public class collide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag=="Finish"){Debug.Log("ok");}
	}
}
