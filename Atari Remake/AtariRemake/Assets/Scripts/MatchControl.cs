using UnityEngine;
using System.Collections;

public class MatchControl : MonoBehaviour {
	
	// public bool isLit;
	CircleCollider2D m_range;
	SpriteRenderer m_Light;
	
	Animator otherAnim;

	void Awake()
	{
		m_range = GetComponent<CircleCollider2D>();
		m_Light = GetComponent<SpriteRenderer>();
		// isLit = false;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.LeftControl) || Input.GetKeyDown (KeyCode.RightControl)) 
		{
			StartCoroutine(Timer (5));
			ScoreControl.use += 1;
			print (ScoreControl.use);
		}
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Item")
		{
			otherAnim = other.gameObject.GetComponent<Animator>();
			otherAnim.SetBool("Disappear", false);
			otherAnim.SetBool("Appear", true);
		}
	}
	
	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Item")
		{
			otherAnim = other.gameObject.GetComponent<Animator>();
			otherAnim.SetBool("Appear", false);
			otherAnim.SetBool("Disappear", true);
		}
	}
	
	IEnumerator Timer (int time)
	{
		m_range.enabled = true;
		m_Light.enabled = true;
		yield return new WaitForSeconds (time);
		m_range.enabled = false;
		m_Light.enabled = false;
		otherAnim.SetBool("Disappear", true);
		otherAnim.SetBool("Appear", false);
	}

}
