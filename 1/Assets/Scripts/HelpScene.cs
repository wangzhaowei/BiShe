using UnityEngine;
using System.Collections;

public class HelpScene : MonoBehaviour {

	void OnClick(){
	Debug.Log("Back to Main Menu!");
	Application.LoadLevel("main menu");		
	}
}
