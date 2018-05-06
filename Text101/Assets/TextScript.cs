using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TextScript : MonoBehaviour {
	public Text text ;
	private enum state
	{
		cell,sheet_0,lock_0,sheet_1,lock_1,mirror,cell_mirror,freedom
	};
	private state mystate;
	// Use this for initialization
	void Start () {
		mystate=state.cell;
	}
	
	// Update is called once per frame
	void Update () {
		if(mystate==state.cell){
			state_cell();
		}else if(mystate==state.sheet_0){
			state_sheet0();
		}else if(mystate==state.sheet_1){
			state_sheet1();
		}else if(mystate==state.lock_0){
			state_lock0();
		}else if(mystate==state.lock_1){
			state_lock1();
		}else if(mystate==state.mirror){
			state_mirror();
		}else if(mystate==state.cell_mirror){
			state_cellmirror();
		}else if(mystate==state.freedom){
			state_freedom();
		}
		
	}
	void state_cell(){
			text.text="You are in a prison cell, and you want to escape.There are"+
			"some dirty sheets on the bed,a mirror on the wall, and the door "+
			"is locked from the outside \n \n"+
			"Press S to view Sheets, M to view Mirror & L to view Locks";
			if(Input.GetKeyDown(KeyCode.S)){
				mystate=state.sheet_0;
			}
			else if(Input.GetKeyDown(KeyCode.M)){
				mystate=state.mirror;
			}else if(Input.GetKeyDown(KeyCode.L)){
				mystate=state.lock_0;
			}
		}
		void state_sheet0(){
			text.text="a mirror on the wall, and the door "+
			"is locked from the outside \n \n"+
			"Press R to return to your cell";
			if(Input.GetKeyDown(KeyCode.R)){
				mystate=state.cell;
			}
			
		}
		void state_sheet1(){
			text.text="You are in a prison cell, and you want to escape.There are"+
			"some dirty sheets on the bed,a mirror on the wall, and the door "+
			"is locked from the outside \n \n"+
			"Press R to return to your cell";
			if(Input.GetKeyDown(KeyCode.R)){
				mystate=state.cell_mirror;
			}
		}
		void state_lock0(){
			text.text="on the bed,a mirror on the wall, and the door "+
			"is locked from the outside \n \n"+
			"Press R to return to your cell";
			if(Input.GetKeyDown(KeyCode.R)){
				mystate=state.cell;
			}
		}
		void state_lock1(){
			text.text="You are in a prison cell, and you want to escape.There are"+
			"some dirty sheets on the bed,a mirror on the wall, and the door "+
			"is locked from the outside \n \n"+
			"Press R to return to your cell  mirror and O for open freedom";
			if(Input.GetKeyDown(KeyCode.R)){
				mystate=state.cell_mirror;
			}else if(Input.GetKeyDown(KeyCode.O)){
				mystate=state.freedom;
			}
		}
		void state_mirror(){
			text.text="You are in a prison cell, and you want to escape.There are"+
			"some dirty sheets on the bed,a mirror on the wall, and the door "+
			"is locked from the outside \n \n"+
			"Press R to return to your cell and T to go cell mirror";
			if(Input.GetKeyDown(KeyCode.R)){
				mystate=state.cell;
			}else if(Input.GetKeyDown(KeyCode.T)){
				mystate=state.cell_mirror;
			}

		}
		void state_cellmirror(){
			text.text="You are in a prison cell, and you want to escape.There are"+
			"some dirty sheets on the bed,a mirror on the wall, and the door "+
			"is locked from the outside \n \n"+
			"Press S to view Sheets 1 & L to view Locks 1";
			if(Input.GetKeyDown(KeyCode.S)){
				mystate=state.sheet_1;
			}
			else if(Input.GetKeyDown(KeyCode.L)){
				mystate=state.lock_1;
			}
		}
		void state_freedom(){
			text.text="You are in a prison cell, and you want to escape.There are"+
			"some dirty sheets on the bed,a mirror on the wall, and the door "+
			"is locked from the outside \n \n"+
			"You Are Free";
			if(Input.GetKeyDown(KeyCode.P)){
				mystate=state.cell;
			}
		}
	}
