using UnityEngine;
using System.Collections;

public class BGMusicControl : MonoBehaviour {
	
	public GameObject obje;
    static public GameObject obj=null;
    // Use this for initialization

	void Start () {
        obj = GameObject.FindGameObjectWithTag("sound");
        if (obj==null) {
            obj = (GameObject)Instantiate(obje);
        }  
    }
}
