using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	[SerializeField] Transform player;

	Vector3 offset;

	void Start ()
    {
		offset = transform.position - player.position;
	}

	void Update ()
	{
		Vector3 target = transform.position + offset;
		transform.position = Vector3.Lerp (transform.position, target, 0);
	}

}
