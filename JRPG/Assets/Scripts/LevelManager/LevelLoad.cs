using UnityEngine;
using System.Collections;

public class LevelLoad : MonoBehaviour {

	public GameObject loader;


	public void Loadlevel(string lvlname)
	{
		Instantiate(loader, Vector3.zero, Quaternion.identity);
		loader.GetComponent<Loadscreenprogress>().Loadlvl(lvlname);

	

	}
}
