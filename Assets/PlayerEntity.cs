using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerEntity : Entity {

	public UnityEvent OnDeathExtra;
	protected override void OnDeath()
    {
		Debug.Log("player death");
        GetComponent<Rigidbody>().AddForce(this.transform.up * 5000);
		OnDeathExtra.Invoke();
    }
}
