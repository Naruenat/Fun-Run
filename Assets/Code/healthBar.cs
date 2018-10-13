using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBar : MonoBehaviour {
	public GameObject heart1, heart2, heart3;
	public static int health;

	void Start () {
		healthBar.health = 3;
		heart1.gameObject.SetActive (true);
		heart2.gameObject.SetActive (true);
		heart3.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		if (healthBar.health == 3) {
			heart1.gameObject.SetActive (true);
			heart2.gameObject.SetActive (true);
			heart3.gameObject.SetActive (true);
		}
		else if(healthBar.health == 2) {
			heart1.gameObject.SetActive (true);
			heart2.gameObject.SetActive (true);
			heart3.gameObject.SetActive (false);
		} 
		else if(healthBar.health == 1) {
			heart1.gameObject.SetActive (true);
			heart2.gameObject.SetActive (false);
			heart3.gameObject.SetActive (false);
		}
		else if(healthBar.health == 0) {
			heart1.gameObject.SetActive (false);
			heart2.gameObject.SetActive (false);
			heart3.gameObject.SetActive (false);
		}
	
	}
		
}

