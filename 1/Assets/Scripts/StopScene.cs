using UnityEngine;
using System.Collections;

public class StopScene : MonoBehaviour {
	
	public GameObject one ;
	public GameObject two ;
	public GameObject three ;
	public GameObject four ;
	public GameObject five ;
	public GameObject six ;
	
	private bool IsGamePaused;
	
	void Start()
    {
    	one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
		four.SetActive(false);
		five.SetActive(false);
		six.SetActive(false);
    }
   
    void Update()
    {  
		
    }
	
	void OnStopButtonClicked()
	{
		if(one){
			if(!one.activeInHierarchy){
				one.SetActive(true);
			}
		}
		else{
			Debug.Log("Dont have object one!");
		}
		if(two){
			if(!two.activeInHierarchy){
				two.SetActive(true);
			}
		}
		else{
			Debug.Log("Dont have object two!");
		}
		if(three){
			if(!three.activeInHierarchy){
				three.SetActive(true);
			}
		}
		else{
			Debug.Log("Dont have object three!");
		}
		if(four){
			if(!four.activeInHierarchy){
				four.SetActive(true);
			}
		}
		else{
			Debug.Log("Dont have object four!");
		}	
		PauseGame();
	}
	
	void OnFanhuiyouxiButtonClicked()
	{
		if (IsGamePaused)
        {
			StartGame();
        }
		one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
		four.SetActive(false);
	}
	
	void OnFanhuizhicaidanButtonClicked()
	{
		Debug.Log("Bcak to Main Menu!");
		Application.LoadLevel("main menu");		
	}
	
	void OnHelpButtonClicked()
	{
		if(five){
			if(!five.activeInHierarchy){
				five.SetActive(true);
			}
		}
		if(six){
			if(!six.activeInHierarchy){
				six.SetActive(true);
			}
		}
		Debug.Log("Help Button Clicked!");	
	}
	
	void OnHuiyouxiButtonClicked()
	{		
		five.SetActive(false);
		six.SetActive(false);
		Debug.Log("Back to Stop Scene!");
	
	}
	
	void StartGame()
	{
		IsGamePaused = false;
        Time.timeScale = 1;
        Debug.Log("Start Game from " + Time.fixedTime);
    }
   
	void PauseGame()
    {
        IsGamePaused = true;
        Time.timeScale = 0;
        Debug.Log("Pause Game");
    }
	
}