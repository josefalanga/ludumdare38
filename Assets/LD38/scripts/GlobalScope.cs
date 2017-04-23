using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
