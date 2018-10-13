using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdleManager : MonoBehaviour {
	public GameObject[] hurdles;
	public float hurdleTime;
	private Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		StartCoroutine (spawnHurdle ());
		print (hurdles.Length);

	}

	IEnumerator spawnHurdle() {
		
		yield return new WaitForSeconds (hurdleTime);
		spawn ();

	}

	void spawn(){
		int randomHurdle = UnityEngine.Random.Range (0,hurdles.Length);
		float[] xpos = new float[3];
		xpos [0] = 0f;
		xpos [1] = 1.141f;
		xpos [2] = -1.141f;

		int RandomXposition = UnityEngine.Random.Range (0,xpos.Length);

		Vector3 hposition = new Vector3 (xpos[RandomXposition], 0f, player.position.z+25);
		Instantiate (hurdles [randomHurdle], hposition, hurdles [randomHurdle].transform.rotation);

		StartCoroutine (spawnHurdle ());
	}



}
