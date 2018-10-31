using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projection : MonoBehaviour {

	int filterNumber;
	GameObject[] filters;
	bool[] filtersValue;
	Clickable script;
	public Material material;
	Color newColor;
	float r;
	float g;
	float b;


	// Use this for initialization
	void Start () {

		filters = GameObject.FindGameObjectsWithTag ("Filter");
		filterNumber = filters.Length;
		filtersValue = new bool[filterNumber];

		material = GetComponent<Renderer> ().material;
		r = 0f;
		g = 0f;
		b = 0f;
		newColor = new Color (r, g, b, 1f);
		material.color = newColor;
		
	}
	
	// Update is called once per frame
	void Update () {
		r = 0f;
		g = 0f;
		b = 0f;
		for (int i = 0; i < filters.Length; i++) {

			script = filters [i].GetComponent<Clickable> ();
			filtersValue [i] = script.isInside; 
		}
		
		for (int i = 0; i < filtersValue.Length; i++) {
			if (filtersValue [i]) {
				script = filters [i].GetComponent<Clickable> ();
				if (script.myColor == Clickable.Colors.A)
					r = 1f;
				if (script.myColor == Clickable.Colors.B)
					b = 1f;
				if (script.myColor == Clickable.Colors.C)
					g = 1f;	

			}
		
		}
		newColor = new Color (r, g, b, 1f);
		material.color = newColor;
	}
}
