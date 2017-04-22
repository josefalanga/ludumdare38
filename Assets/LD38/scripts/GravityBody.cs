using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Rigidbody))]
public class GravityBody : MonoBehaviour {
	public 
    new Rigidbody rigidbody;

    void Awake () {
		rigidbody = GetComponent<Rigidbody> ();
		rigidbody.useGravity = false;
	}
}
