using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] float Speed = 5.0f;
	
	public float v, h;

	Vector3 m_Movement;
	Rigidbody2D m_PlayerRigidbody;
	GameObject stairs;
	
	void Awake ()
	{
		m_PlayerRigidbody = GetComponent<Rigidbody2D> ();
	}

	void Update ()
	{
		h = Input.GetAxisRaw ("Horizontal");
		Move (h, v);
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.tag == "Stairs") 
		{
			v = Input.GetAxisRaw ("Vertical");
			m_PlayerRigidbody.gravityScale = 0f;	
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Stairs") 
		{
			v = 0;
			m_PlayerRigidbody.gravityScale = 9.8f;		
		}
	}

	void Move(float h, float v)
	{
		m_Movement.Set (h, v, 0);
		m_Movement = m_Movement.normalized * Speed * Time.deltaTime;
		m_PlayerRigidbody.MovePosition (transform.position + m_Movement);
	}
}
