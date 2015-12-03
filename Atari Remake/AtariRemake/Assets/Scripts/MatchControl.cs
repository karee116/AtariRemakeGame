using UnityEngine;
using System.Collections;

public class MatchControl : MonoBehaviour {
	
	// public bool isLit;
	public int use;
	Animator m_anim;

	void Awake()
	{
		m_anim = GetComponent<Animator> ();
		use = 0;
		// isLit = false;
	}

	void Update ()
	{
		if ((Input.GetKeyDown (KeyCode.LeftControl) || Input.GetKeyDown (KeyCode.RightControl)) && m_anim.GetBool("Light") != true) {
			StartCoroutine(Timer (5));
			use += 1;
		}

	}
	
	// this seems to stick on the bool being false so find a way to fix it later please
	IEnumerator Timer (int time)
	{
		m_anim.SetBool("Light", true);
		yield return new WaitForSeconds (time);
		m_anim.SetBool("Light", false);
	}

}
