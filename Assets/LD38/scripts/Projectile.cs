using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	void Start()
	{
		Invoke("SelfDestruct",10);
	}

	void SelfDestruct()
	{
		Destroy(this.gameObject);
	}

	void OnCollisionEnter(Collision other)
	{		
		if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Player"))
		{
			other.gameObject.GetComponent<Rigidbody>().AddExplosionForce(200,transform.position,10);
			other.gameObject.GetComponent<Entity>().TakeDamage(50);
		}
		SelfDestruct();
	}
}
