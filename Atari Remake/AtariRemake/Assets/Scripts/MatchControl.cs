using UnityEngine;
using System.Collections;

public class MatchControl : MonoBehaviour {
	
	// public bool isLit;
	// CircleCollider2D m_range;
	Color obj;
	Animator otherAnim;

	void Awake()
	{
		// m_range = GetComponent<CircleCollider2D>();
		// isLit = false;
	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.LeftControl) || Input.GetKeyDown (KeyCode.RightControl)) {
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
			otherAnim.SetBool("Appear", true);
		}
	}
	
	void OnTriggerExit2D (Collider2D other)
	{
		obj = other.gameObject.GetComponent<SpriteRenderer>().color;
		obj.a -= .02f;
		print ("bye");
	}
	
	IEnumerator Timer (int time)
	{
		yield return new WaitForSeconds (time);
	}

}
