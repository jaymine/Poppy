using UnityEngine;
using System.Collections;

public class Play : MyState {
	
	public GameManage manager;
	public int startTime; 
	public Play (GameManage managerRef)
	{
		manager = managerRef;
		if(Application.loadedLevelName != "Scene_game")
		Application.LoadLevel("Scene_game");
		startTime=(int)Time.realtimeSinceStartup;
		
	}

	// Use this for initialization
	public void stateUpdate () {
		
		
		
	}
	
	// Update is called once per frame
	public void showIt () {
		if(GameManage.time<100){
		GameManage.time=(int)Time.realtimeSinceStartup-startTime;	
		}
		GUI.Button(new Rect(10, 10, 250, 60),"Time:"+GameManage.time.ToString()+"/80");
		
		if(GameManage.time>=80){
			
			
			manager.SwitchState (new LossState (manager));
		}
		if(GameManage.time<80 && GameObject.Find("player").transform.position.y>38 
			&& GameObject.Find("player").transform.position.x<= -2){
			//GameObject.Destroy(GameObject.Find("GameManager"));
			manager.SwitchState (new WinState (manager));
		}
	}
}
