using UnityEngine;
using System.Collections;

public class DontDesBGMusic : MonoBehaviour {

    // Use this for initialization
    void Start() {
    DontDestroyOnLoad(this.gameObject);
    }
     
}
