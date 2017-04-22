using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public GameObject projectile;

	float gunCooldown = 0.1f;
	float timeSinceLastShot = 0;

	public void Fire()
	{
		if (timeSinceLastShot > gunCooldown)
		{
			timeSinceLastShot = 0;
			GameObject m_projectile = GameObject.Instantiate(projectile,transform.position,Quaternion.identity);
			m_projectile.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1500);	
		}			
	}

	void Update()
	{
		timeSinceLastShot += Time.deltaTime;
		if (Input.GetKeyDown(KeyCode.Mouse0))
         {
             Fire();
         }
	}
}
