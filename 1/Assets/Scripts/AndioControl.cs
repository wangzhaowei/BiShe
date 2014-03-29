using UnityEngine;
using System.Collections;

public class AndioControl : MonoBehaviour {

	public UIScrollBar sb ;
	protected AudioSource source ;

	void Start () { 
		sb.onChange += this.OnScrollbarChange;
		AudioSource aSource = BGMusicControl.obj.GetComponent<AudioSource>();
		if(aSource != null){
			source = aSource;
		}
	}

	void OnScrollbarChange(UIScrollBar sbar)
	{
		Debug.Log( " OnScrollbarChange_" + sbar.scrollValue) ;
		source.volume = sbar.scrollValue ;
	} 
}