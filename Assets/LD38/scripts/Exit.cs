﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
        	Application.Quit();
		}
		if (Input.GetKeyDown(KeyCode.R)) {
        	SceneManager.LoadScene(0);
		}
	}
}
