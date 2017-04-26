using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameAnalyticsSDK;
using UnityEngine.SceneManagement;

public class GlobalScope : MonoBehaviour {
	public static GameObject planet
	{
		get{
			return GameObject.FindGameObjectWithTag("Planet");
		}
	}

    private static int enemiesLeft = 0;

    public static int EnemiesLeft {
		get{
			return enemiesLeft;
		}
		set{
			enemiesLeft = enemiesLeft < 0 ? 0 : value;		
		}
	}

	void Start()
	{
		GameAnalytics.NewProgressionEvent(GAProgressionStatus.Start, "Round");
	}
}
