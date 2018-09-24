using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

	private Animator anim;
	//private Renderer render;
	private bool win;
	private bool gameOver;
	private bool playing = true;
	private float countdown = 3f;


	// Use this for initialization
	void Start () {
		anim = GameObject.Find("kimi0").GetComponent<Animator>();
		//render = GameObject.Find("enemies").GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {		
		if(!playing){
			Debug.Log("starting end timer", null);
			countdown -= Time.deltaTime;
			if(countdown < 0){
				SceneManager.LoadScene("Menu");
			}
		} else {
			win = anim.GetBool("Win");
			gameOver = anim.GetBool("GameOver");

			if(win){
				playing = false;
				//Destroy(GameObject.Find("enemies"), 0f);
				Debug.Log("you win!", null);
			}

			if(gameOver){
				SceneManager.LoadScene("MainGame");
			}	
		} 
	}
}
