using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemToPlayer : MonoBehaviour {

//	public static Sprite spriteInUse;
//	GameObject itemInUse;
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
			break;
			case "UrnPiece_1":
			break;
			case "UrnPiece_2":
			break;
			case "UrnPiece_3":
			break;
			case "Gem":
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
