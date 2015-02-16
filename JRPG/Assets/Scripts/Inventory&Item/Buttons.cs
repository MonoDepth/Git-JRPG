using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour,IPointerDownHandler{

	public enum btntype {
		Use,
		Dispose,
		Equip

	}
	StatManager st;
	Inventory inventory;
	public btntype buttontype;


	void Start () {
		st = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().st;
		inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory>();
	
	}

	void Update () {
	
	}
	public void OnPointerDown(PointerEventData data)
	{
		int check = 0;
		DescriptionBox active = GetComponentInParent<DescriptionBox>();


		if (buttontype == btntype.Use) {

					check = UseItem (active.activeItem, active.inx);
				} 
		else if (buttontype == btntype.Dispose) {

			check = DisposeItem(active.activeItem, active.inx);
		}

		if (check == 1)
		{
			active.gameObject.SetActive(false);
		}

	}

	int UseItem(Item itm, int indx)
	{
		try
		{
		if (itm.type == Item.ItemType.Consumable) {

			if( StatManager.hp + inventory.items[indx].typeValue <= StatManager.maxHp)
				StatManager.hp += inventory.items[indx].typeValue;
			else
			{
				StatManager.hp = StatManager.maxHp;
			}
			inventory.items[indx] = new Item();
			}

			return 1;
		}

		catch
		{
			return 0;
		}

	}

	int DisposeItem(Item itm, int indx)
	{
		try
		{
		inventory.items[indx] = new Item();
		return 1;
		}
		catch
		{
			return 0;
		}
	}
}
