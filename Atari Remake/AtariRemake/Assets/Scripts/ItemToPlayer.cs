using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemToPlayer : MonoBehaviour {

	public static Sprite spriteInUse;
	GameObject itemInUse;
	// public GameObject objectInUse;
	
	void Awake ()
	{
		itemInUse = GameObject.Find("ItemInUse");
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Item" )
		{
			spriteInUse = other.gameObject.GetComponent<SpriteRenderer>().sprite;
			spriteInUse = itemInUse.GetComponent<Sprite>();
			Debug.Log(itemInUse.GetComponent<Sprite>());
			other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			// other.gameObject.SetActive(false);
		}
	}
}
