using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.GetComponent<Rigidbody>() != null) other.gameObject.GetComponent<Rigidbody>().AddExplosionForce(200,other.contacts[0].point,10);
	}
}
