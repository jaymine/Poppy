using UnityEngine;
using System.Collections;

public class WinState : MyState {

	private GameManage manager;
	public WinState (GameManage managerRef)
	{
		manager = managerRef;
		if(Application.loadedLevelName != "Scene_win")
		Application.LoadLevel("Scene_win");
	}
	
	// Update is called once per frame
	public void stateUpdate () {
		
	}
	
	public void showIt () {
		GUI.Label(new Rect(200,100,200,100),"Score:"+(50-GameManage.time/2));
		if (GUI.Button(new Rect(10, 10, 250, 60),"Press Here or Any Key to Continue")){
			manager.SwitchState (new Play (manager));
		}
		
	}
}
