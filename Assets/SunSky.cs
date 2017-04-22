using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunSky : MonoBehaviour {

	public GameObject sun;
	public Color day;
	public float dayDistance;
	public Color mid;
	public float midDistance;
	public Color night;
	public float nightDistance;

	[SpaceAttribute(10)]
	public float currentDistance;
	
	void Update()
	{
		currentDistance = Vector3.Distance(this.transform.position, sun.transform.position);
		float minDistance = currentDistance < midDistance ? dayDistance : midDistance;
		float maxDistance = currentDistance < midDistance ? midDistance : nightDistance;;
		GetComponent<Camera>().backgroundColor = Color.Lerp(
			currentDistance < midDistance ? day : mid, 
			currentDistance < midDistance ? mid : night, 
			((currentDistance - minDistance) * 100 / (maxDistance - minDistance)) / 100
			);
	}
}
