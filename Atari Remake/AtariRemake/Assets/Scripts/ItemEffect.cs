using UnityEngine;
using System.Collections;

public class ItemEffect : MonoBehaviour {

	ItemToPlayer item
	{get; set;}
	
	void OnTriggerEnter2D (Collider2D other)
	{
//		if (other.gameObject.tag != "Floor" && other.gameObject.tag != "Stairs")
//		{
			if (other.gameObject.tag == "LockedDoor")
			{
//				if (item.inventory.name == "Key")
//				{
					other.gameObject.GetComponent<EdgeCollider2D>().enabled = false;
//				}
//				else
//				{
//					Debug.Log ("This door is locked");
//				}
			}
			
		//}
	}
}
