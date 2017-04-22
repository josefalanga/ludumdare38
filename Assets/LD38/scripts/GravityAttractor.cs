using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour {

	public float gravityOnCenter = -9.8f;
	List<Rigidbody> bodiesInRange = new List<Rigidbody>();
	
	void FixedUpdate()
	{
		foreach(Rigidbody body in bodiesInRange)
		{
			Attract(body);
		}
	}

	void OnTriggerEnter(Collider other)
	{		
		if (other.attachedRigidbody != null)
		{
			bodiesInRange.Add(other.attachedRigidbody);
			other.attachedRigidbody.constraints = RigidbodyConstraints.FreezeRotation;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.attachedRigidbody != null)
		{
			bodiesInRange.Remove(other.attachedRigidbody);
			other.attachedRigidbody.constraints = RigidbodyConstraints.None;
		}
	}

	public void Attract(Rigidbody body) {
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.transform.up;

		float gravityStrenght = gravityOnCenter / (Vector3.Distance(body.transform.position,this.transform.position) + 0.1f);
		
		// Apply downwards gravity to body
		body.AddForce(gravityUp * gravityStrenght);
		// Allign bodies up axis with the centre of planet
		body.rotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
	}  
}
