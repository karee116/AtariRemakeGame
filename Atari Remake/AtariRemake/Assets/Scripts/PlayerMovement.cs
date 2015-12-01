using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	[SerializeField] float Speed = 5.0f;

	Vector3 m_Movement;
	Rigidbody2D m_PlayerRigidbody;
	GameObject stairs;
	
	void Awake ()
	{
		m_PlayerRigidbody = GetComponent<Rigidbody2D> ();

	}

	void Update ()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		Move (h);
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject == stairs) {
			if (Input.GetKey (KeyCode.UpArrow)) {
				float v = Input.GetAxisRaw ("Vertical");

				m_Movement.Set (0, v, 0);
				m_Movement = m_Movement.normalized * Speed * Time.deltaTime;
				m_PlayerRigidbody.MovePosition (transform.position + m_Movement);
			}
		}
	}

	void Move(float h)
	{
		m_Movement.Set (h, 0, 0);
		m_Movement = m_Movement.normalized * Speed * Time.deltaTime;
		m_PlayerRigidbody.MovePosition (transform.position + m_Movement);
	}
}
