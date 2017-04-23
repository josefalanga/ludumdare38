using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {
	void Update()
	{
		if (Input.GetButtonDown(KeyCode.Escape.ToString()))
		{
			Application.Quit();
		}
	}
}
