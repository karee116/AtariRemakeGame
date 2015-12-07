using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemToScreen : MonoBehaviour {

	Image itemInUse;
	Text matchUse;
	MatchControl litCount;
	ItemToPlayer item;
	
	void Awake()
	{
		itemInUse = GetComponent<Image>();
		matchUse = GetComponentInChildren<Text>();
	}
	
	void Udpate ()
	{
		matchUse.text = " x " + litCount.use;
		itemInUse.sprite = item.spriteInUse;
	}
}
