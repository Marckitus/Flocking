using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockManager : MonoBehaviour
{
	public GameObject fishPrefab;
	public int numFish = 50;
	public GameObject[] allFish;
	public Vector3 swimLimits = new Vector3(7, 5, 7);

	[Header("Fish Settings")]
	[Range(0.0f, 5.0f)]
	public float minSpeed = 0;
	[Range(0.0f, 5.0f)]
	public float maxSpeed = 3;
	[Range(1.0f, 10.0f)]
	public float neighbourDistance = 10;
	[Range(0.0f, 5.0f)]
	public float rotationSpeed = 3;

	// Use this for initialization
	void Start()
	{
		allFish = new GameObject[numFish];
		for (int i = 0; i < numFish; i++)
		{
			Vector3 pos = this.transform.position + new Vector3(Random.Range(-swimLimits.x, swimLimits.x),
																  Random.Range(-swimLimits.y, swimLimits.y),
																  Random.Range(-swimLimits.z, swimLimits.z));
			allFish[i] = (GameObject)Instantiate(fishPrefab, pos, Quaternion.identity);
			allFish[i].GetComponent<Flock>().myManager = this;
		}

	}

	// Update is called once per frame
	void Update()
	{

	}
}