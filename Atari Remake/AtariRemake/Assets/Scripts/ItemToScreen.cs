using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemToScreen : MonoBehaviour {

	public Sprite itemInUse;
	Text matchUse;
		
	public static int use
	{get; set;}
	
	void Awake()
	{
//		itemInUse = GetComponent<Image>().sprite;
		matchUse = GetComponentInChildren<Text>();
		use = 0;
	}
	
	void Udpate ()
	{
		matchUse.text = " Apples" + use;
		itemInUse = ItemToPlayer.spriteInUse;
	}
}
