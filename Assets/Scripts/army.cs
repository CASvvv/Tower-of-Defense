using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class army : MonoBehaviour {

	public int Level;
	public int Power;
	public int HP;

	public float moveSpeed;
	private Transform _transform;

	// Use this for initialization
	void Start () {
		Power = Level;
		HP = Level * 3;

		_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		_transform.position += _transform.up * moveSpeed;
	}

	public void Dead () {
		Destroy (this.gameObject);
	}

	public void Damage (int damage) {
		HP -= damage;

		if (HP <= 0) {
			Dead ();
		}
	}

	void OnCollisionEnter2D (Collision2D enemy) {
		if ((gameObject.CompareTag ("player") && enemy.gameObject.CompareTag ("enemy"))
			|| (gameObject.CompareTag ("enemy") && enemy.gameObject.CompareTag ("player"))) {
			enemy.gameObject.GetComponent<army> ().Damage (Power);

			_transform.position += _transform.up * (-1f);;
		}
	}
}
