using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed;
	Vector2 origin = new Vector2(0,0);
	Vector2 org;
	public string lvlnametoload;
	GameObject levelmanager;
	public StatManager st = new StatManager();
	// Use this for initialization
	void Start () {
		levelmanager = GameObject.FindGameObjectWithTag("LevelManager");
		org = rigidbody2D.position;

	}
	
	// Update is called once per frame
	void Update () {
		origin = Vector2.zero;

		if (Input.GetKey (KeyCode.W)) {
			origin.y += speed;	
		}

		if (Input.GetKey (KeyCode.A)) {
			origin.x -= speed;//rigidbody2D.MovePosition(new Vector2(rigidbody2D.position.x - speed, rigidbody2D.position.y));	
		}
		if (Input.GetKey (KeyCode.S)) {
			origin.y -= speed;	
		}
		if (Input.GetKey (KeyCode.D)) {
			origin.x += speed;
		}

		rigidbody2D.MovePosition (rigidbody2D.position + origin * Time.deltaTime);
		if (Input.GetKey (KeyCode.Alpha1)) {
			Debug.Log(StatManager.hp);
		}

		if(Input.GetKeyDown(KeyCode.F1))
		levelmanager.GetComponent<LevelLoad>().Loadlevel(lvlnametoload);

	}

	void OnGUI()
	{
		StatManager.hp = (int)GUI.VerticalSlider (new Rect (0, 0, 20, 100), StatManager.hp, StatManager.maxHp, 0);
	}
}
