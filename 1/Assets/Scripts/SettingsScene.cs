using UnityEngine;
using System.Collections;

public class SettingsScene : MonoBehaviour {
	void OnHuizhijiemianButtonClicked(){
	Debug.Log("Back to Main Menu!");
	Application.LoadLevel("main menu");		
	}
	void OnAboutButtonClicked(){
	Debug.Log("About Button Clicked!");
	Application.LoadLevel("about scene");		
	}
	void OnResetButtonClicked(){
	Debug.Log("Reset Button Clicked!");
	//Application.LoadLevel("settings scene");		
	}
}
