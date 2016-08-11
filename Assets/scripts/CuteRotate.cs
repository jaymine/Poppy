using UnityEngine;
using System.Collections;

public class CuteRotate : MonoBehaviour {
	
	float x_min=2;
	float x_max=-2;
	float speed=20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(transform.eulerAngles.x>=120){
		transform.Rotate(2 * Time.deltaTime, 0, 0);	
		}
		if(transform.eulerAngles.x>=320){
		transform.Rotate(-2 * Time.deltaTime, 0, 0);	
		}
	}
}
