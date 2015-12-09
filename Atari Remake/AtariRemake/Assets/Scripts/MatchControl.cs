using UnityEngine;
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
		if ((Input.GetKeyDown (KeyCode.LeftControl) || Input.GetKeyDown (KeyCode.RightControl)) && m_anim.GetBool("Light") != true) {
			StartCoroutine(Timer (5));
			ScoreControl.use += 1;
			print (ScoreControl.use);
		}
	}
	
	IEnumerator Timer (int time)
	{
		m_anim.SetBool("Light", true);
		yield return new WaitForSeconds (time);
		m_anim.SetBool("Light", false);
	}

}
