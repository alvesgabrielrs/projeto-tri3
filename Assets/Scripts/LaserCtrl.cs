﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserCtrl : MonoBehaviour {

	public float speed = 30f;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rb.velocity = Vector2.right * speed;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "MainCamera"){
			Destroy (this.gameObject);
		}
	}
}
