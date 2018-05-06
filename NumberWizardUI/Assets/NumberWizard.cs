using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
public int maxguess=11;
public int max=2000;
public int min=0;
public int guess;
public Text text;
	// Use this for initialization
	void Start () {
		nextguess();
		
	}
	
	public void guessmax(){
		min=guess;
		nextguess();

	}
	public void guessmin(){
		max=guess;
		nextguess();
		
	}
	public void nextguess(){
		guess=Random.Range(min,max+1);
		maxguess=maxguess-1;

		text.text="MY Next Guess Is "+guess;
		if(maxguess<0){
			Application.LoadLevel("win");
			text.text="";
		}
	}

	
}
