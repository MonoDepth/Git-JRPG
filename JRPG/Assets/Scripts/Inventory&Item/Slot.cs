using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Slot : MonoBehaviour, IPointerDownHandler
{

	public Item item;
	Image img;
	public int index;
	Inventory inventory;
	StatManager st;
	public static GameObject descbox;

	// Use this for initialization
	void Start () {
		inventory = GameObject.FindGameObjectWithTag ("Inventory").GetComponent<Inventory>();
		//st = GameObject.FindGameObjectWithTag("Player").GetComponent<Movement>().st;
		img = gameObject.transform.GetChild (0).GetComponent<Image> ();
		if (descbox == null) {
			descbox = GameObject.FindGameObjectWithTag ("DescBox");
			descbox.SetActive(false);
				}




	}
	
	// Update is called once per frame
	void Update () {

		if (inventory.items[index].itemName != null) {
		

			img.enabled = true;
			img.sprite = inventory.items[index].icon;
			//Debug.Log(

				} 
		else 
		{
			img.enabled = false;

		}
	
	}


	public void OnPointerDown(PointerEventData data)
	{
		Use ();
	}

	public void Use()
	{
		if (inventory.items [index].itemName != null) {
						Debug.Log (descbox);
						descbox.SetActive (true);
						descbox.GetComponent<DescriptionBox> ().Popup (inventory.items [index], index);
				}
		
		/*if (inventory.items[index].type == Item.ItemType.Consumable) {

			//Debug.Break();
			//Debug.Log("Healed 25HP");
			if( st.hp + inventory.items[index].typeValue <= st.maxHp)
				st.hp += inventory.items[index].typeValue;
			else
			{
				st.hp = st.maxHp;
			}
			inventory.items[index] = new Item();
		}*/
	}
}
