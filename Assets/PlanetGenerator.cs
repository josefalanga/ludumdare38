using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGenerator : MonoBehaviour {
	public GameObject scenarioContainer;
	public GameObject[] scenarioObjects;
	private List<Transform> scenarioPlaces = new List<Transform>();

	[SpaceAttribute(10)]
	public GameObject dynamicsCotainer;
	public GameObject[] dynamicObjects;	
	private List<Transform> dynamicsPlaces = new List<Transform>();

	void Awake()
	{
		for (int i = 0; i < scenarioContainer.transform.childCount; i++)
		{
			scenarioPlaces.Add(scenarioContainer.transform.GetChild(i));
		}	

		for (int i = 0; i < dynamicsCotainer.transform.childCount; i++)
		{
			dynamicsPlaces.Add(dynamicsCotainer.transform.GetChild(i));
		}		
	}

	void Start()
	{
		StartCoroutine(PlaceSomething(scenarioPlaces.ToArray(),scenarioObjects));
		StartCoroutine(PlaceSomething(dynamicsPlaces.ToArray(),dynamicObjects));
	}

	IEnumerator PlaceSomething(Transform[] places, GameObject[] objects)
	{
		foreach(Transform place in places)
		{
			GameObject newObject = 	GameObject.Instantiate(objects[Random.Range(0,objects.Length)]);	
			newObject.transform.SetParent(place);
			newObject.transform.localPosition = Vector3.zero;
			AlignToPlanetCenter(newObject.transform);
			yield return null;
		}
	}

	public void AlignToPlanetCenter(Transform m_transform) {
		Vector3 gravityUp = (m_transform.position - transform.position).normalized;
		Vector3 localUp = m_transform.transform.up;	

		// Allign bodies up axis with the centre of planet
		m_transform.rotation = Quaternion.FromToRotation(localUp,gravityUp) * m_transform.rotation;
	} 
}
