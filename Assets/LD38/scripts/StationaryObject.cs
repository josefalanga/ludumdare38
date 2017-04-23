using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StationaryObject : MonoBehaviour {
	Rigidbody m_rigidbody;
	float timeStatic = 0;
	float targetTime = 2;
	
	void Awake()
	{
		m_rigidbody = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		if (m_rigidbody.isKinematic) return;

		if (m_rigidbody.velocity.magnitude < 0.001f)
		{
			timeStatic += Time.fixedTime;
		}
		else
		{
			timeStatic = 0;
		}

		m_rigidbody.isKinematic = timeStatic > targetTime;
	}
}
