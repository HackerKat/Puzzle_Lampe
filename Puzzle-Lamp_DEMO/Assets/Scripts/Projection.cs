using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projection : MonoBehaviour {

	int filterNumber;
	GameObject[] filters;
	bool[] filtersValue;
	Clickable script;
	public string text = "";


	// Use this for initialization
	void Start () {

		filters = GameObject.FindGameObjectsWithTag ("Filter");
		filterNumber = filters.Length;
		filtersValue = new bool[filterNumber];

		text = GetComponent<TextMesh> ().text;
		
	}
	
	// Update is called once per frame
	void Update () {
		text = "";
		for (int i = 0; i < filters.Length; i++) {

			script = filters [i].GetComponent<Clickable> ();
			filtersValue [i] = script.isInside; 
		}
		
		for (int i = 0; i < filtersValue.Length; i++) {
			if (filtersValue [i]) {
				script = filters [i].GetComponent<Clickable> ();
				if (script.myColor == Clickable.Colors.A)
					text += "A";
				if (script.myColor == Clickable.Colors.B )
					text += "B";
				if (script.myColor == Clickable.Colors.C )
					text += "B";	

			}
		
		}
	}
}
