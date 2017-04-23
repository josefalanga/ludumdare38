using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	GameObject target;
	Rigidbody m_rigidbody; 
	public float seekRange = 30;
	public bool seeking;
	float maxMoveSpeed = 50.0f;//kill the player!
	public float moveSpeed;

	Vector3 moveAmount;
	Vector3 smoothMoveVelocity;

	void Awake()
	{
		m_rigidbody = GetComponent<Rigidbody>();
		target = GameObject.FindGameObjectWithTag("Player");
	}

	void FixedUpdate()
	{
		if (!seeking)
		{
			//patrolling
			transform.Rotate(transform.up, 2f);
		}
		else
		{
			//seeking
			transform.LookAt(target.transform.position,transform.up);
		}
		
		moveSpeed = maxMoveSpeed / (GlobalScope.EnemiesLeft > 0 ? GlobalScope.EnemiesLeft : 1);
		moveAmount = Vector3.SmoothDamp(moveAmount,Vector3.forward * moveSpeed,ref smoothMoveVelocity,.15f);
		m_rigidbody.MovePosition(m_rigidbody.position + transform.TransformDirection(moveAmount) * Time.fixedDeltaTime);
	}

	void Update()
	{
		seeking = Vector3.Distance(transform.position,target.transform.position) < seekRange;
	}
}
