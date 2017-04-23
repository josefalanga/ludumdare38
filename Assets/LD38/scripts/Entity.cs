using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	public bool isded = false;
	public int health = 100;
	public AudioSource damageSound;

	public void TakeDamage(int damage)
	{
		if (damageSound != null) damageSound.Play();
		health -= damage;
		if (health <= 0)
		{
			OnDeath();
		}
	} 


	void FixedUpdate()
	{
		if (Vector3.Distance(GlobalScope.planet.transform.position, transform.position) > 60)
		{
			OnDeath();
		}
	}

	protected abstract void OnDeath();
}
