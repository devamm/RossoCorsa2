using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript3 : MonoBehaviour {
	public Transform rep2;
	public float moveSpeed;
	public float moveTime;
	public float interval;

	private float moveCounter;
	private float intervalCounter;
	private bool moving = true;
	private float direction = 1f;

	// Use this for initialization
	void Start () {
		rep2 = GameObject.Find("reporter3").GetComponent<Transform>();	
		intervalCounter = interval;
		moveCounter = moveTime;

	}
	
	// Update is called once per frame
	void Update () {
		if(moving){
			moveCounter -= Time.deltaTime;
		
			if (direction < 0){
				rep2.Translate(Vector3.right * moveSpeed);
			} else {
				rep2.Translate(-Vector3.right * moveSpeed);
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
		if(obj.gameObject.tag == "wall" || obj.gameObject.tag == "enemy" ){
			direction *= -1;
		}
	}
}
