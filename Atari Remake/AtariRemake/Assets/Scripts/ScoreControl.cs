using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreControl : MonoBehaviour {

	Text matchUse;
	
	public static int use
	{get; set;}
	
	void Awake()
	{
		matchUse = GetComponent<Text>();
		use = 0;
	}
	
	void Update ()
	{
		matchUse.text = "x " + use;
	}
}
