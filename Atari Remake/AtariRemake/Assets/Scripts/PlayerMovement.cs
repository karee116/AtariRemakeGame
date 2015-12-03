using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] float Speed = 5.0f;
	
	public float v, h;

	Vector3 m_Movement;
	Rigidbody2D m_PlayerRigidbody;
	GameObject[] floor;
	BoxCollider2D ground;
	
	void Awake ()
	{
		m_PlayerRigidbody = GetComponent<Rigidbody2D> ();
		floor = GameObject.FindGameObjectsWithTag("Floor");
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
		
		RaycastHit2D floorHit = Physics2D.Raycast(transform.position, Vector2.up, 5f);
		
		foreach (var level in floor) {
			ground = level.GetComponent<BoxCollider2D>();
			
			print ("Floors recognized");
			
			// need help here
			if (floorHit.collider == ground)
			{
				ground.enabled = false;
				print ("Raycast fired");
			}
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
