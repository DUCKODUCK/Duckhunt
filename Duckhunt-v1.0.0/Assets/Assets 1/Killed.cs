using UnityEngine;
using System.Collections;

public class Killed : MonoBehaviour {

	public GameObject dog;
	public Animator dogAnims;

	void OnTriggerEnter2D () {
		dogAnims.SetBool ("BirdHit", true);
	}
}
