using UnityEngine;
using System.Collections;

public class ItemToPlayer : MonoBehaviour {

	public static Sprite spriteInUse;
	public GameObject objectInUse;
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject == GameObject.FindGameObjectWithTag("Item"))
		{
			objectInUse = other.gameObject;
			spriteInUse = objectInUse.GetComponent<Sprite>();
			other.gameObject.SetActive(false);
		}
	}
}
