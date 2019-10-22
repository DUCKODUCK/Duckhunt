using UnityEngine;
using System.Collections;

public class bullets : MonoBehaviour
{
	public GameObject[] bullet;

	void Update () {
	if (StaticVars.bullets <= 3 ) {
			print(StaticVars.bullets);
		bullet[StaticVars.bullets].SetActive(false);		
	}
	}
}

