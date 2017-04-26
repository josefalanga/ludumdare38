using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using GameAnalyticsSDK;

public class PlayerEntity : Entity {

	public UnityEvent OnDeathExtra;
	protected override void OnDeath()
    {
		if (!isded)
		{
			isded = true;
			Debug.Log("player death");
			GameAnalytics.NewProgressionEvent(GAProgressionStatus.Fail, "Round");	
       		GetComponent<Rigidbody>().AddForce(this.transform.up * 5000);
			OnDeathExtra.Invoke();			
		}		
    }

	void OnCollisionStay(Collision other)
	{
		if(other.gameObject.CompareTag("Enemy"))
		{
			GetComponent<Rigidbody>().AddForce(transform.forward*-100);
		}		
	}	

	void OnDestroy()
	{
		if (GlobalScope.EnemiesLeft == 0 && !isded)
		{
			GameAnalytics.NewProgressionEvent(GAProgressionStatus.Complete, "Round");	
		}
	}
}
