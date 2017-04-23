﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainHud : MonoBehaviour {
	public Text enemyCount;
	public Entity playerEntity;

	void OnGUI()
	{
		enemyCount.text = GlobalScope.EnemiesLeft > 0 ? 
		"ENEMIES: " + GlobalScope.EnemiesLeft.ToString() + "     HP: " + playerEntity.health.ToString() : 
		"CONGRATULATIONS,\nYOU KILLED ALL YOU ENEMIES \n\n\n\nNOW YOU ARE ALONE FOREVER \n\n<size=130>GAME OVER</size>";
	}
}
