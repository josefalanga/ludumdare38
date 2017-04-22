using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class RainbowImage : MonoBehaviour {

	Image m_image;
	float duration = 0.2f;
	// Use this for initialization
	void Awake () {
		m_image = GetComponent<Image>();
	}

	void Start()
	{
		InvokeRepeating("ChangeColor",0,duration);
	}
	
	void ChangeColor () {
		m_image.DOColor(Color.HSVToRGB(Random.Range(0.0f,1.0f),1.0f,1.0f),duration);
	}
}
