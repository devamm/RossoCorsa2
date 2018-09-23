using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reporterScript : MonoBehaviour {

	public float speed;
	private Transform player;

	void Start () {
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards(transform.position, player.position, speed);
	}
}
