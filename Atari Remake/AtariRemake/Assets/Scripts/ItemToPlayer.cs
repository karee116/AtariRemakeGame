using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemToPlayer : MonoBehaviour {

	

//	public static Sprite spriteInUse;
	GameObject inventory;
	// public GameObject objectInUse;
	
	void Awake ()
	{
		//itemInUse = GameObject.Find("ItemInUse");
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Item" )
		{
			switch (other.gameObject.name) {
			
			case "Key":
				inventory = GameObject.Find("Key");
//				inventory.GetComponent<SpriteRenderer>().enabled = false;
//				inventory.GetComponent<Collider2D>().enabled = false;
				break;
			case "UrnPiece_1":
				inventory = GameObject.Find("UrnPiece_1");
//				inventory.GetComponent<SpriteRenderer>().enabled = false;
//				inventory.GetComponent<Collider2D>().enabled = false;
				break;
			case "UrnPiece_2":
				inventory = GameObject.Find("UrnPiece_2");
//				inventory.GetComponent<SpriteRenderer>().enabled = false;
//				inventory.GetComponent<Collider2D>().enabled = false;
				break;
			case "UrnPiece_3":
				inventory = GameObject.Find("UrnPiece_3");
//				inventory.GetComponent<SpriteRenderer>().enabled = false;
//				inventory.GetComponent<Collider2D>().enabled = false;
				break;
			case "Gem":
				inventory = GameObject.Find("Gem");
//				inventory.GetComponent<SpriteRenderer>().enabled = false;
//				inventory.GetComponent<Collider2D>().enabled = false;
				break;
			default:
				break;
			}
//			spriteInUse = other.gameObject.GetComponent<SpriteRenderer>().sprite;
//			spriteInUse = itemInUse.GetComponent<Sprite>();
//			Debug.Log(itemInUse);
//			other.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			// other.gameObject.SetActive(false);
		}
		
		
		
	}
}
