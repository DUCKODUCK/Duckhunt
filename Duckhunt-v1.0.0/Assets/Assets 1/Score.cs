using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public int score;
	public Text scoreText;

	void Update () {
		scoreText.text = "Score: " + StaticVars.gameScore;
	}

}

