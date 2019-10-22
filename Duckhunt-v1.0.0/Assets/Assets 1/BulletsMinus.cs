using UnityEngine;
using System.Collections;

public class BulletsMinus : MonoBehaviour
{

	public void OnMouseDown () {
				if (StaticVars.bullets > 0) {
						StaticVars.bullets--;
				}
		}
}

