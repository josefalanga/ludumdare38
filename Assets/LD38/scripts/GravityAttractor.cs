using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour {

	public float gravityOnCenter = -9.8f;
	public List<Rigidbody> bodiesInRange = new List<Rigidbody>();
	
	void FixedUpdate()
	{
		for (int i = 0; i < bodiesInRange.Count;i++)
		{
			while (bodiesInRange[i] == null)
			{
				bodiesInRange.RemoveAt(i);
			}
			Attract(bodiesInRange[i]);
			AlignToPlanetCenter(bodiesInRange[i].transform);
		}
	}

	void OnTriggerEnter(Collider other)
	{		
		if (other.attachedRigidbody != null)
		{
			bodiesInRange.Add(other.attachedRigidbody);
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.attachedRigidbody != null)
		{
			bodiesInRange.Remove(other.attachedRigidbody);
		}
	}

	public void Attract(Rigidbody body) {

		body.constraints = RigidbodyConstraints.FreezeRotation;
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.transform.up;

		float gravityStrenght = gravityOnCenter / (Vector3.Distance(body.transform.position,this.transform.position) + 0.1f);
		
		// Apply downwards gravity to body
		body.AddForce(gravityUp * gravityStrenght);		
	}  

	public void AlignToPlanetCenter(Transform m_transform) {
		Vector3 gravityUp = (m_transform.position - transform.position).normalized;
		Vector3 localUp = m_transform.transform.up;	

		// Allign bodies up axis with the centre of planet
		m_transform.rotation = Quaternion.FromToRotation(localUp,gravityUp) * m_transform.rotation;
	}
}
