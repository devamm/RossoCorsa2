using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

	private Animator anim;
	private Renderer card;
	private bool win;
	private bool gameOver;
	private bool playing = true;
	private float countdown;


	// Use this for initialization
	void Start () {
		anim = GameObject.Find("kimi0").GetComponent<Animator>();
		card = GameObject.Find("winCard").GetComponent<Renderer>();
		card.enabled = false;
		countdown = 2f;
	}
	
	// Update is called once per frame
	void Update () {		
		if(!playing){
			countdown -= Time.deltaTime;
			if(countdown < 0){
				SceneManager.LoadScene("Menu");
			}
		} else {
			win = anim.GetBool("Win");
			gameOver = anim.GetBool("GameOver");

			if(win){
				playing = false;
				card.enabled = true;
			}

			if(gameOver){
				SceneManager.LoadScene("MainGame");
			}	
		} 
	}
}
