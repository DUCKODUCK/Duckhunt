using UnityEngine;
using System.Collections;

public class DogHappy : MonoBehaviour
{
	public GameObject DogObject;
	public Animator dogAnims;

	void OnTriggerEnter2D () {	
		dogAnims.SetBool ("BirdHit", true);
	}
}

