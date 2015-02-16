using UnityEngine;
using System.Collections;

public class TerrainLoader : MonoBehaviour {

	int levelWidth, levelHeight; //Map size
	public Transform grassTile, brickTile, player, missingo; //Gets the different blocks used in the game
	public Color grassColor, brickColor, spawnColor; //Gets the different colors used in the terrain maps for each block 
	public Camera cam;

	Color[] tileColors;

	public Texture2D levelMap; //Map to load
	
	
	void Start () {
		Application.targetFrameRate = 60;
		levelHeight = levelMap.height;
		levelWidth = levelMap.width;
		Loadlevel ();
	}

	void Update () {
	
	}

	void Loadlevel()
	{
		tileColors = new Color[levelWidth * levelHeight]; //Creates an empty array for each color on the map
		tileColors = levelMap.GetPixels (); //Assigns a color to each empty array slot from the level map

		for (int y = 0; y < levelHeight; y++) { //Nestled loop for placing each block on the level

			for(int x = 0; x < levelWidth; x++) //Building the map horizontally then 1 step down vertically 
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
