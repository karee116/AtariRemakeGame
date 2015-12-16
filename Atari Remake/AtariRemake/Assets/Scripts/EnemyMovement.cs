using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	[SerializeField] float m_Speed;

	Transform player;
	Transform enemy;
	
	void Awake ()
	{
		enemy = GetComponent<Transform>();
		player = GameObject.Find ("Player").transform;
	}
	
	void OnTriggerEnter2D (Collider2D other)
	{
		enemy.position = Vector3.Lerp (enemy.position, player.position, m_Speed * Time.deltaTime);
	}
	
}
