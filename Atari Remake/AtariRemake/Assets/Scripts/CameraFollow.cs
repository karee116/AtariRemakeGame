using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	Transform player; // reference to the player

	void Start ()
    {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}

	void Update ()
	{
		Vector3 target = new Vector3 (player.position.x, player.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, target, 5);
	}

}
