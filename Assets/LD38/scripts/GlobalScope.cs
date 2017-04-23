using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalScope : MonoBehaviour {
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
