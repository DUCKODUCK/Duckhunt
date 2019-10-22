using UnityEngine;
using System.Collections;

public class BirdKilled : MonoBehaviour {

	
	
	void OnTriggerEnter2D (Collider2D Duck){
		Object.Destroy(Duck.gameObject);
	}

}
