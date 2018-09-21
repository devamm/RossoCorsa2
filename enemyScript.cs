﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {
	public Transform rep1;
	public float moveSpeed;
	public float moveTime;
	public float interval;

	private float moveCounter;
	private float intervalCounter;
	private bool moving = true;
	

	// Use this for initialization
	void Start () {
		rep1 = GameObject.Find("reporter1").GetComponent<Transform>();	
		intervalCounter = interval;
		moveCounter = moveTime;

	}
	
	// Update is called once per frame
	void Update () {
		if(moving){
			moveCounter -= Time.deltaTime;
		
			if (direction < 0){
				rep1.Translate(Vector3.right * moveSpeed);
			} else {
				rep1.Translate(-Vector3.right * moveSpeed);
			}
			
			if(moveCounter < 0){
				moving = false;
				intervalCounter = interval;
				direction = Random.Range(-1f, 1f);
			}
		} else {
			intervalCounter -=Time.deltaTime;
			if(intervalCounter < 0){
				moving = true;
				moveCounter = moveTime;
				direction = Random.Range(-1f, 1f);
			
			}
		}
	}
	void OnCollisionEnter2D(Collision2D obj){
		if(obj.gameObject.tag == "wall"){
			direction *= -1;
		}
	}
}
