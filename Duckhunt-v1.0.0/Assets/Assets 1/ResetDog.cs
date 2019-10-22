using UnityEngine;
using System.Collections;

public class ResetDog : MonoBehaviour {

	public Animator dogAnims;

	void DogReset () {
		dogAnims.SetBool ("BirdMiss", false);
		dogAnims.SetBool ("BirdHit", false);
	}
}
