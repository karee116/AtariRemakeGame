using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemToPlayer : MonoBehaviour {

	public GameObject inventory;
	[SerializeField] Sprite key, urn1, urn2, urn3, gem;
	[SerializeField] Image itemInUse;
	[SerializeField] Transform[] urnSpots;
	
	public static int win;
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Item" )
		{
			switch (other.gameObject.name) {
			
			case "Key":
				inventory = GameObject.Find("Key");
				itemInUse.sprite = key;
//				inventory.GetComponent<SpriteRenderer>().enabled = false;
//				inventory.GetComponent<Collider2D>().enabled = false;
				break;
			case "UrnPiece_1":
				inventory = GameObject.Find("UrnPiece_1");
				itemInUse.sprite = urn1;
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
			
			Debug.Log (inventory.name);
		}
		
		if ((other.gameObject.name == "CompleteUrn") && (inventory.name == "UrnPiece_1"))
		{	
			inventory.transform.position = urnSpots[0].position;
			win += 1;
			
		}
		else if ((other.gameObject.name == "CompleteUrn") && (inventory.name == "UrnPiece_2"))
		{
			inventory.transform.position = urnSpots[1].position;
			win += 1;
		}
		else if ((other.gameObject.name == "CompleteUrn") && (inventory.name == "UrnPiece_3"))
		{
			inventory.transform.position = urnSpots[2].position;
			win += 1;
		}
		
	}
	
	void OnCollisionEnter2D (Collision2D coll)
	{
		if ((coll.gameObject.tag == "LockedDoor") && (inventory.name == "Key"))
		{
			coll.gameObject.GetComponent<Collider2D>().enabled = false;
		}
	}
}
