using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public bool m_dead;

	int lives;
	Vector3 startingPosition;
	
	void Awake()
	{
		startingPosition = transform.position;
		lives = 9;
		m_dead = false;
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			lives -= 1;
			transform.position = startingPosition;
			
			if (lives <= 0)
			{
				m_dead = true;
			}
		}
	}
	
}
