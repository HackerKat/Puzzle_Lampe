using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour {
	int layerMask;
	public bool isInside = false;
	public enum Colors {
		A, B, C
	};
	public Colors myColor;
    public GameObject lenseLight;

	// Use this for initialization
	void Start () {
		
		
		layerMask = LayerMask.GetMask("Clickable");
	}
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

		if (Physics.Raycast (ray, out hit, 1000.0f, layerMask) ) {
			if (Input.GetMouseButtonDown(0) && !isInside) {
				Debug.Log("box should move inside the cube");
				transform.Translate(1f, 0, 0);
				isInside = true;
                lenseLight.SetActive(true);
			}
			else if (Input.GetMouseButtonDown(0) && isInside)
			{
				Debug.Log("box should move outside the cube");
				transform.Translate(-1f, 0, 0);
				isInside = false;
                lenseLight.SetActive(false);
			}		
		
		}

	}

//	void OnMouseOver(){
//		RaycastHit hit;
//		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//
//		if (Physics.Raycast (ray, out hit, 1000.0f, layerMask) ) {
//			if (Input.GetMouseButton(0) && !isInside) {
//				Debug.Log("box should move inside the cube");
//				transform.Translate(1f, 0, 0);
//				isInside = true;
//			}
//			else if (Input.GetMouseButton(0) && isInside)
//			{
//				Debug.Log("box should move outside the cube");
//				transform.Translate(-1f, 0, 0);
//				isInside = false;
//			}		
//
//		}
//
//	}
}
