using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {

	[SerializeField]
	public bool rightRotate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D army) {
		if (army.gameObject.CompareTag("player")) {
			army.transform.position += army.transform.up * (-0.1f);
			if (rightRotate) {
				army.transform.Rotate (new Vector3 (0, 0, 90));
			} else {
				army.transform.Rotate (new Vector3 (0, 0, -90));
			}
		}
		if (army.gameObject.CompareTag("enemy")) {
			army.transform.position += army.transform.up * (-0.1f);
			if (rightRotate) {
				army.transform.Rotate (new Vector3 (0, 0, -90));
			} else {
				army.transform.Rotate (new Vector3 (0, 0, 90));
			}
		}
	}
}
