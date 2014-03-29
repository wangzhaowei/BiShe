using UnityEngine;
using System.Collections;

public class DontDesMusic : MonoBehaviour {

	public GameObject MusicBk;
	public static bool IsHaveMusicBk = false;

    private GameObject clone;

	// Use this for initialization
	void Start () {
		if(!IsHaveMusicBk){

			clone = Instantiate(MusicBk,transform.position,transform.rotation) as GameObject;
			IsHaveMusicBk = true;

		}
		DontDestroyOnLoad(clone);
	}
	
	// Update is called once per frame
	void Update () {	
	}
}

