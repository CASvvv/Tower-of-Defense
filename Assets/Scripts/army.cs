using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class army : MonoBehaviour {

	public float moveSpeed;
	private Transform _transform;

	// Use this for initialization
	void Start () {
		_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		_transform.position += _transform.up * moveSpeed;
	}
}
