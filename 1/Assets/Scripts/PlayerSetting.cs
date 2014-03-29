using UnityEngine;
using System.Collections;

public class PlayerSetting: MonoBehaviour {

	public UIInput playername;
	public UIInput playernumber;
	
	void OnSubmit()
	{
		Debug.Log("Play Game with Name: " +playername.text+" Number:" +playernumber.text);
	}
	
	void OnZuojiantouButtonClicked(){
	Debug.Log("Zuojiantou Button Clicked!");
	//Application.LoadLevel("Guanyu scene");		
	}
	
	void OnYoujiantouClicked(){
	Debug.Log("Youjiantou Button Clicked!");
	//Application.LoadLevel("settings scene");		
	}
}
