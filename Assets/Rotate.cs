using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public Vector3 fixedRotation;
	void FixedUpdate()
	{
		this.transform.Rotate(fixedRotation);
	}
}
