using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

	protected int health = 100;

	public void TakeDamage(int damage)
	{
		health -= damage;
		if (health <= 0)
		{
			OnDeath();
		}
	} 

	protected abstract void OnDeath();
}
