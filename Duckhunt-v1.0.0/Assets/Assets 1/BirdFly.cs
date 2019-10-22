using UnityEngine;
using System.Collections;

public class BirdFly : MonoBehaviour
{
	public float speed = .05f;
	public bool direction = true;

	void Start () {
		ResetDirection ();
	}

	void Update () {
		if (direction) {
			transform.position += new Vector3 (speed, speed);
		} else {
			transform.position += new Vector3 (speed * -1, speed);
		}
	}

	void OnTriggerEnter2D () {
		ResetDirection ();
	}

	void ResetDirection () {
		direction = (Random.value < .5);
	}
}

