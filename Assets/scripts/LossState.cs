using UnityEngine;
using System.Collections;

public class LossState : MyState {
	
	private GameManage manager;
	public LossState (GameManage managerRef)
	{
		manager = managerRef;
		if(Application.loadedLevelName != "Scene_loss")
		Application.LoadLevel("Scene_loss");
	}

	// Use this for initialization
	public void stateUpdate () {
	
	}
	
	// Update is called once per frame
	public void showIt () {
		
		if (GUI.Button(new Rect(10, 10, 250, 60),"Press Here or Any Key to Continue") ){
			manager.SwitchState (new Play (manager));
		}
		
	}
}
