using UnityEngine;
using System.Collections;

public class DieFall : MonoBehaviour {

	public BirdFly FlyState;
	public BirdFall FallState;
	public Animator BirdAnim;


	public void OnMouseDown () {
		if (StaticVars.bullets > 0) {
			StaticVars.gameScore++;
			FlyState.enabled = false;
			FallState.enabled = true;
			BirdAnim.enabled = false;
		}

	
	}

}
