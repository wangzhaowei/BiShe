using UnityEngine;
using System.Collections;

public class AboutScene : MonoBehaviour {

	void OnClick(){
	Debug.Log("Back to Settings Scene!");
	Application.LoadLevel("settings scene");		
	}
	
}
