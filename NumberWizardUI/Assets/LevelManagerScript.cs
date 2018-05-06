using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagerScript : MonoBehaviour {

	public void LoadLevel(string name){
		print("hello world"+ name);
		Application.LoadLevel(name);
	}

	public void quit(){
		print("bye world");
		Application.Quit();

	}
} 
