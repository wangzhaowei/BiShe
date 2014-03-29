using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	void OnStartButtonClicked(){
	Debug.Log("Start Button Clicked!");
	Application.LoadLevel("player setting");		
	}
	void OnHelpButtonClicked(){
	Debug.Log("Help Button Clicked!");
	Application.LoadLevel("help scene");		
	}
	void OnSettingsButtonClicked(){
	Debug.Log("Settings Button Clicked!");
	Application.LoadLevel("settings scene");		
	}
}
