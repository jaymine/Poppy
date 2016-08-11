using UnityEngine;
using System.Collections;

public class GameManage : MonoBehaviour {
	
	public static int time;
	
	public GameManage(){
		
	}
	
	MyState myState;
	// Use this for initialization
	void Start () {
		myState=new StartState(this);
	}
	
	// Update is called once per frame
	
	void Update(){
		if (myState != null)
		myState.stateUpdate();
		DontDestroyOnLoad(gameObject);
	}
	
	void OnGUI(){
		//if(myState != null)
		myState.showIt();
	}

	public void Restart(){
		Application.LoadLevel("Scene_start");
	}
	
	public void SwitchState(MyState newState){
		myState=newState;
	}
}
