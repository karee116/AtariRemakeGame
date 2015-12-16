using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public static bool m_dead;
	
	int lives;
	Vector3 startingPosition;
	Animator end;
	
	void Awake()
	{
		startingPosition = transform.position;
		lives = 9;
		m_dead = false;
		end = GameObject.Find("Screen").GetComponent<Animator>();
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			lives -= 1;
			transform.position = startingPosition;
			other.gameObject.SetActive(false);
			
			if (lives <= 0)
			{
				m_dead = true;
				end.SetTrigger("Done");
			}
		}
	}
	
}
