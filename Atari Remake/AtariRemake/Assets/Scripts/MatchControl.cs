﻿using UnityEngine;
using System.Collections;

public class MatchControl : MonoBehaviour {
	
	// public bool isLit;
	Animator m_anim;

	void Awake()
	{
		m_anim = GetComponent<Animator> ();
		// isLit = false;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.LeftControl) || Input.GetKeyDown (KeyCode.RightControl)) {
			m_anim.SetBool("Light", true);
		}
		StartCoroutine(Timer (10));
		StopCoroutine (Timer (10));
	}
	
	// this seems to stick on the bool being false so find a way to fix it later please
	IEnumerator Timer (int time)
	{
		yield return new WaitForSeconds (time);
		m_anim.SetBool("Light", false);
	}

}
