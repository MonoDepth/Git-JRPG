using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Loadscreenprogress : MonoBehaviour {

	Image[] img;
	string lvl;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		Debug.Log("test");

			Debug.Log(Application.GetStreamProgressForLevel(lvl));



		if(img == null)
			img = GetComponentsInChildren<Image>();
		
		foreach(Image ig in img)
		ig.fillAmount = Application.GetStreamProgressForLevel(lvl);


	/*	if(Application.loadedLevelName == lvl && lvl != null)
		Destroy(this.gameObject);*/
	}

	public void Loadlvl(string name)
	{
		enabled = true;
		try{DontDestroyOnLoad(this);}
		catch{Debug.Log("Don't destroy error");}
		try{lvl = name;}
		catch{Debug.Log("name error");}
		try{Application.LoadLevel(lvl);}
		catch{Debug.Log("Level load error");}

	}
}
