using System.Collections;
using System.Collections.Generic;
using GameAnalyticsSDK;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) {
			GameAnalytics.NewProgressionEvent(GAProgressionStatus.Undefined, "Exit Game");
        	Application.Quit();
		}
		if (Input.GetKeyDown(KeyCode.R)) {	
			GameAnalytics.NewProgressionEvent(GAProgressionStatus.Undefined, "Restart Round");
        	SceneManager.LoadScene(0);
		}
	}
}
