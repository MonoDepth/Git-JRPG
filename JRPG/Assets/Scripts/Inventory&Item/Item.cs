using UnityEngine;
using System.Collections;

public class Item{

	public string itemName, flavorText, rarityType;
	public int ItemID, value, typeValue;
	public Sprite icon;
	public ItemType type;

	public enum ItemType
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
		icon = Resources.LoadAll<Sprite> (@"SpriteSheets/ItemSheet")[ItemID];
		//icon = 
		Debug.Log (icon.name);
		this.type = type;

	}

	public Item()
	{

	}

}
