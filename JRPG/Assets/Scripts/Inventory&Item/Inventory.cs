using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<GameObject> slots = new List<GameObject> ();
	public List<Item> items = new List<Item> ();
	public GameObject slot;
	float x = -112f;
	float tmpX, tmpY;
	float y = 136f;
	int slotnum = 0;

	ItemDataBase database;
	// Use this for initialization
	void Start () {

		database = GameObject.FindGameObjectWithTag ("ItemDataBase").GetComponent<ItemDataBase> ();

		tmpX = x;
		tmpY = y;
		for(int i = 0; i < 6; i++)
		{
			for (int t = 0; t < 5; t++)
			{
				GameObject sl = (GameObject)Instantiate(slot);
				sl.GetComponent<Slot>().index = slotnum;
				slots.Add(sl);
				items.Add(new Item());
				sl.transform.SetParent(this.gameObject.transform); 
				sl.GetComponent<RectTransform>().localPosition = new Vector3(tmpX, tmpY);
				tmpX += 55;
				slotnum ++;
				sl.name = slotnum.ToString();

			}
			tmpX = x;
			tmpY -= 55;

			addItem(1);
			//Debug.Log(items[0].itemName);
		}
		addItem(0);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addItem(int ID)
	{

		foreach (Item i in database.Itembase)
		{
			if(i.ItemID == ID)
			{ 
				addAtEmpty(i);
				break;
			}
		}
	}

	public void addAtEmpty(Item item)
	{
		for (int i = 0; i < items.Count; i++) {
		
			if(items[i].itemName == null)
			{
				items[i] = item;

				break;
			}
		}
	}
}
