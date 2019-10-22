using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KillBirdOriginal : MonoBehaviour {
		
		public GameObject Bird;
		public GameObject Dog;
		public int score;
		public Animator myAnims;
		public Text scoreText;
		
		void Start ()
		{
			Screen.orientation = ScreenOrientation.LandscapeLeft;
			score = 0;
			UpdateScore ();
		}
		
		void OnMouseDown () {					
			BirdOff ();
			Dog.SetActive (true);
			score += 10;
			UpdateScore ();
			BirdOn ();
		}
		
		void UpdateScore () {
			scoreText.text = "Score: " + score;
		}
		
		void BirdOff () {
			myAnims.SetBool ("Hit", false);
			Bird.SetActive (false);
			Dog.SetActive (false);
		}
		
		void BirdOn () {
			Bird.SetActive (true);
		}
	}

