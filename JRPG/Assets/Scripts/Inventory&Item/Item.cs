using UnityEngine;
using System.Collections;

public class Item{

	public string itemName, flavorText, rarityType; //The Item's name, description text and rarity type("common", "rare", etc.)
	public int ItemID, value, typeValue; //The Item's specific ID, sell value, value specific to the item type (damage, heal amount, etc.)
	public Sprite icon;
	public ItemType type;

	public enum ItemType //The item types available, used to identify item actions
	{
		Armor,
		Weapon,
		Shield, 
		Consumable, 
		Accessory,
		QuestItem,
		Materials,
		Tools

	}

	public Item(string name, string desc, string rarity, int ID, int value, int typeValue, ItemType type)
	{
		itemName = name;
		flavorText = desc;
		rarityType = rarity;
		ItemID = ID;
		this.value = value;
		this.typeValue = typeValue;
		icon = Resources.LoadAll<Sprite> (@"SpriteSheets/ItemSheet")[ItemID]; //The icon is  loaded from a spritesheet using the ID as its index
		//icon = 
		Debug.Log (icon.name);
		this.type = type;

	}

	public Item() //Only used to create empty Item shells, instead of using null as a value
	{

	}

}
