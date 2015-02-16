using UnityEngine;
using System.Collections;

public class LevelSave : MonoBehaviour {

	public string path;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q))
		{
			try
			{
				float test = PlayerPrefs.GetFloat("Health", 100f);
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
