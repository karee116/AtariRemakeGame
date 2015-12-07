using UnityEngine;
using System.Collections;

public class ItemToPlayer : MonoBehaviour {

	public Sprite spriteInUse;
	public GameObject objectInUse;
	
	void OnTriggerEnter2D (Collider2D other)
	{
		objectInUse = other.gameObject;
		spriteInUse = objectInUse.GetComponent<Sprite>();
		Destroy(other.gameObject);
	}
}
