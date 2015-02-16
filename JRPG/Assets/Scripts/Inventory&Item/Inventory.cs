using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<GameObject> slots = new List<GameObject> (); //Global slot list and item list
	public List<Item> items = new List<Item> ();
	public GameObject slot; //Used for the slot instantiastion
	float x = -112f;
	float tmpX, tmpY; //Values for the start position for the slots
	float y = 136f;
	int slotnum = 0; //Slot index number

	ItemDataBase database;
	void Start () {

		database = GameObject.FindGameObjectWithTag ("ItemDataBase").GetComponent<ItemDataBase> (); //Getting the database object in the scene 

		tmpX = x;
		tmpY = y;
		for(int i = 0; i < 6; i++) //Nestled loop to handle the creation of the inventory slots
		{
			for (int t = 0; t < 5; t++)
			{
				GameObject sl = (GameObject)Instantiate(slot);
				sl.GetComponent<Slot>().index = slotnum; //Setting the index of the slot
				slots.Add(sl); //adding the slot to the list
				items.Add(new Item()); //Give the slot an item shell
				sl.transform.SetParent(this.gameObject.transform); 
				sl.GetComponent<RectTransform>().localPosition = new Vector3(tmpX, tmpY);
				tmpX += 55; //adding distance for the next slot
				slotnum ++;
				sl.name = slotnum.ToString(); //The slot will be named after the index

			}
			tmpX = x;
			tmpY -= 55; // Beginning the next row of slots

			addItem(1); //Adds an item with ID 1 (in this case a potion) at every new row for testing purposes only
		}
		addItem(0); //for testing purposes only

	}

	void Update () {
	
	}

	public void addItem(int ID)
	{

		foreach (Item i in database.Itembase)
		{
			if(i.ItemID == ID)
			{ 
				addAtEmpty(i); //Adds the item with the specific ID at the first empty slot
				break;
			}
		}
	}

	public void addAtEmpty(Item item)
	{
		for (int i = 0; i < items.Count; i++) {
		
			if(items[i].itemName == null) //Checks if the item is an actual item or a shell
			{
				items[i] = item; //if it's a shell we've found an empty slot and we then proceed to fill the slot with an item
				break;
			}
		}
	}
}
