using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int min;  
	int max;	
	int guess;
	int maxGuessAllowed = 5;

	public Text text;

	void StartGame () {
		min = 1;
		max = 1000;
		NextGuess ();
	}

	void Start () {
		StartGame ();
		text.text = "Is your number higher or lower than " + guess;
	}

	public void GuessHigher () {
		min = guess;
		NextGuess();
	}

	public void GuessLower () {
		max = guess;
		NextGuess ();
	}

	void NextGuess () {
		guess = Random.Range (min, max + 1);
		text.text = "Is your number higher or lower than " + guess;
		maxGuessAllowed = maxGuessAllowed - 1;
		if (maxGuessAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}