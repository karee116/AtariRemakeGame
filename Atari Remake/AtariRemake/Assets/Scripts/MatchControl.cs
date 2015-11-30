using UnityEngine;
using System.Collections;

public class MatchControl : MonoBehaviour {
	
	public bool isLit;
	Animator m_anim;

	void Awake()
	{
		m_anim = GetComponent<Animator> ();
		isLit = false;
	}

	void Lit ()
	{
		if (Input.GetKeyDown (KeyCode.LeftControl) || Input.GetKeyDown (KeyCode.RightControl)) {
			isLit = true;
			m_anim.SetBool ("MatchLit", isLit);
			StartCoroutine (Timer (15));
			// return;
		}

//		 isLit = false;
//		 m_anim.SetBool ("MatchLit", isLit);
	}
	
	IEnumerator Timer (int time)
	{
		yield return new WaitForSeconds (time);
	}

}
