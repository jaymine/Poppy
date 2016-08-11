using UnityEngine;
using System.Collections;

public class StartState : MyState {
	
	private GameManage manager;
	public StartState (GameManage managerRef)
	{
		manager = managerRef;
		if(Application.loadedLevelName != "Scene_start")
		Application.LoadLevel("Scene_start");
	}

	// Use this for initialization
	public void stateUpdate () {
	
	}
	
	// Update is called once per frame
	public void showIt () {
		if (GUI.Button(new Rect(10, 10, 250, 60),"Press Here or Any Key to Continue") ||Input.anyKeyDown){
			manager.SwitchState (new Play (manager));
		}
	}
}
