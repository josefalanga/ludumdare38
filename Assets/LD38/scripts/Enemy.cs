using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
	void Awake()
	{
		GlobalScope.EnemiesLeft += 1;
	}

    protected override void OnDeath()
    {
        Destroy(this.gameObject);
    }

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			other.gameObject.GetComponent<Entity>().TakeDamage(50);
		}
	}

	void OnDestroy()
	{
		GlobalScope.EnemiesLeft -= 1;
	}
}
