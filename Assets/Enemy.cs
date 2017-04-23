using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
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
}
