using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDataBase : MonoBehaviour {

	public List<Item> Itembase = new List<Item>();
	// Use this for initialization
	void Start () {
		Itembase.Add(new Item("Practice Sword", "Your practice sword, not sharp at all", "Common", 0, 0, 2, Item.ItemType.Weapon));
		Itembase.Add (new Item ("Small potion", "Heals you 25HP", "Ultra Rare", 1, 2000, 25, Item.ItemType.Consumable));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
