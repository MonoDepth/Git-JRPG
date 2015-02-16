using UnityEngine;
using System.Collections;

public class TerrainLoader : MonoBehaviour {

	int levelWidth, levelHeight;
	public Transform grassTile, brickTile, player, missingo;
	public Color grassColor, brickColor, spawnColor;
	public Camera cam;

	Color[] tileColors;

	public Texture2D levelMap;
	

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 60;
		levelHeight = levelMap.height;
		levelWidth = levelMap.width;
		Loadlevel ();


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Loadlevel()
	{
		tileColors = new Color[levelWidth * levelHeight];
		tileColors = levelMap.GetPixels ();

		for (int y = 0; y < levelHeight; y++) {

			for(int x = 0; x < levelWidth; x++)
			{	int point = x + y * levelWidth;
				if(tileColors[point] == grassColor)
				{
					Instantiate(grassTile, new Vector3(x, y), Quaternion.identity);
				}

				else if(tileColors[point] == brickColor)
				{
					Instantiate(brickTile, new Vector3(x, y), Quaternion.identity);
				}

				else if (tileColors[point] == spawnColor)
				{
					player.transform.position = new Vector3(x,y);
					Instantiate(grassTile, new Vector3(x, y), Quaternion.identity);
				}
				else
				{
					Instantiate(missingo, new Vector3(x, y), Quaternion.identity);
				}
			}

		}
	}
}
