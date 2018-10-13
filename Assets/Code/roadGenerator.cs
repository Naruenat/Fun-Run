using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadGenerator : MonoBehaviour {
	private float spawnz; //= -3f;
	public GameObject[] prefabs;
	private float safeZone = 15f;
	private int amountOfRoads = 3;


	private List<GameObject> roadsList;
	private Transform playertransform;

	private float RoadLength = 236f;

	// Use this for initialization
	void Start () {
		roadsList = new List<GameObject> ();
		playertransform = GameObject.FindGameObjectWithTag ("Player").transform;
		for (int i = 0; i < amountOfRoads; ++i)
			SpawnRoad (UnityEngine.Random.Range(0,prefabs.Length-1));
		
	}
	
	// Update is called once per frame
	void Update () {
		if (playertransform.position.z - safeZone > (spawnz - amountOfRoads * RoadLength)) {
			SpawnRoad (UnityEngine.Random.Range(0,prefabs.Length-1));
			DeleteRoad ();
		}
		
	}

	void SpawnRoad(int prefabIndex =-1 ){
		GameObject go;

		go = Instantiate (prefabs [prefabIndex]) as GameObject;
		go.transform.SetParent (transform);
		go.transform.position = Vector3.forward * (spawnz-236f);
		spawnz += RoadLength;
		//add to list
		roadsList.Add(go);

	}

	void DeleteRoad (){
		Destroy (roadsList [0]);
		roadsList.RemoveAt (0);
	}
}
