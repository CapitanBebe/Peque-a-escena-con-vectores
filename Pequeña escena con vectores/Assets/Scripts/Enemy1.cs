using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
	// Propiedades
	Quaternion targetRotation;
	public Transform target;
	public float speed = 0.1F;
	bool rotating = false;
	float rotationTime;

	void Update()
	{
		staring();
	}
	void staring()
    {
		Vector3 relativePosition = target.position - transform.position;
		targetRotation = Quaternion.LookRotation(relativePosition);
		rotating = true;
		rotationTime = 0;

		if (rotating)
		{
			rotationTime += Time.deltaTime * speed;
			transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationTime);
			if (rotationTime > 1)
			{
				rotating = false;
			}
		}
	}
}
