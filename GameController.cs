using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

	private Animator anim;
	private Renderer menuRender;
	private bool win;
	private bool gameOver;
	private bool menu;


	// Use this for initialization
	void Start () {
		menu = true;
		anim = null;
		DontDestroyOnLoad(this);
		menuRender = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {		
		if(menu){
			menuRender.enabled = true;
			if(Input.GetKeyDown(KeyCode.Space)){
				menu = false;
				SceneManager.LoadScene("MainGame");
				
			}
		} else {
			menuRender.enabled = false;
			anim = GameObject.Find("kimi0").GetComponent<Animator>();
			win = anim.GetBool("Win");
			gameOver = anim.GetBool("GameOver");
			
			if(win){
				Debug.Log("You won!", null);
				menu = true;
				SceneManager.LoadScene("Menu");
			} 
			if(gameOver){
			Debug.Log("Game over", null);
			SceneManager.LoadScene("MainGame");
			
			}
		}
	}
}
