using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int min;
	int max;
	int guess;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			min = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.DownArrow))
		{
			max = guess;
			NextGuess();
		}
		else if(Input.GetKeyDown(KeyCode.Return))
		{
			print ("I win!");
		}
	
	}
	
	void StartGame()
	{
		min = 1;
		max = 1000;
		guess = 500;
		
		print("Welcome to Number Wizard!");
		print("Pick a number in your head, but, don't tell me!");
		print("The lowest you can guess is " + min);
		print("The highest you can guess is " + max);
		print ("Is your number higher or lower than " + guess + "?");
		print ("Press up arrow for higher, down arrow for lower, or return for equals");
		
		max = max + 1;
		
	}
	
	void NextGuess()
	{
		guess = (max + min) / 2;
		print ("Is your number higher or lower than " + guess + "?");
		print ("Press up arrow for higher, down arrow for lower, or return for equals");
	}
	
}
