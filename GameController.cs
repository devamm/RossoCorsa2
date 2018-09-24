using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

	private Animator anim;
	private bool win;
	private bool gameOver;


	// Use this for initialization
	void Start () {
		anim = GameObject.Find("kimi0").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {		
		Debug.Log("game running", null);
		win = anim.GetBool("Win");
		gameOver = anim.GetBool("GameOver");

		if(gameOver){
			SceneManager.LoadScene("MainGame");
		}
		if(win){
			SceneManager.LoadScene("Menu");
		}	
	}
}
