using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print("This Is My Challenge");
		int max=1000;
		int min=1;
		print ("Pick A Number in your head, but dont tell me  between "+min+" and "+max);
		print("Is number higher or lower than 500");
		print("press up arrow for higher and down arrow for lower");

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
			print("upper key pressed");
		}else if(Input.GetKeyDown(KeyCode.DownArrow)){
			print("down key pressed");
		}else if(Input.GetKeyDown(KeyCode.Return)){
			print("return pressed");
		}
	}
	
}
