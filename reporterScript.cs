using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reporterScript : MonoBehaviour {

	public float speed;
	public float interval;
	public float moveTime;

	private float intervalCounter;
	private float moveTimeCounter;
	private bool moving = true;
	private Transform player;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		intervalCounter = interval;
		moveTimeCounter = moveTime;
	}
	
	// Update is called once per frame
	void Update () {
		if(moving){
			moveTimeCounter -=Time.deltaTime;
			transform.position = Vector2.MoveTowards(transform.position, player.position, speed);
			if(moveTimeCounter < 0){
				moving = false;
				intervalCounter = interval;
			}
		} else {
			intervalCounter -=Time.deltaTime;
			moveTimeCounter = moveTime;
			if(intervalCounter < 0){
				moving = true;
				moveTimeCounter = moveTime;
			}
		}
	}
}
