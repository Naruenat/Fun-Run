using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurdle : MonoBehaviour {

	void OnTriggerEnter(Collider col){
		healthBar.health -= 1;
	}
}
