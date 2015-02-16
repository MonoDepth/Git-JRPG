using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DescriptionBox : MonoBehaviour {

	Text[] txts;
	Image[] imgs;
	public Item activeItem;
	public int inx;
	// Use this for initialization
	void Start () {
		txts = gameObject.GetComponentsInChildren<Text> ();
		imgs = gameObject.GetComponentsInChildren<Image> ();
	
	
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	public void Popup(Item Self, int indx) //Sets the icon and description of the object in a popup box 
	{

		activeItem = Self;
		inx = indx;
		foreach (Text txt in txts) 
		{
			if (txt.name == "Flavor") //Makes sure the right text and image element is set
				{
				txt.text = Self.flavorText;
				break;
				}

		}
		foreach (Image pic in imgs)
		{
			if (pic.name == "Icon")
				{
				pic.sprite = Self.icon;
				break;
				}

		}

		


	}
}
