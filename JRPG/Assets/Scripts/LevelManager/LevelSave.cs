using UnityEngine;
using System.Collections;

public class LevelSave : MonoBehaviour {

	public string path;
	void Start () {

	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Q))
		{
			try
			{
				float test = PlayerPrefs.GetFloat("Health", 100f); //NOT YET WORKED ON, JUST TEMPORARY TEST, WILL BE CHANGED IN THE FUTURE
				Debug.Log(test.ToString());
				PlayerPrefs.SetFloat("Health", 50f);
			}

			catch (PlayerPrefsException e)
			{
				Debug.Log(e);
			}
		}
	}
}
