using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	[SerializeField] Transform player;

	Vector3 offset;

	void Start ()
    {
		offset = transform.position - player.position;
	}

	void FixedUpdate ()
	{


}
