﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KimiAnimator : MonoBehaviour {
	Transform kimi;
	private Animator anim; 
	public float speed;

	void Start () {
		kimi = GameObject.Find("kimi0").GetComponent<Transform> ();
		anim = GameObject.Find("kimi0").GetComponent<Animator>();
		anim.SetBool("Win", false);
		anim.SetBool("GameOver", false);

	}

	void Update () {
		if(Input.GetKey(KeyCode.W)){
			kimi.Translate(Vector3.up * speed);
			anim.SetBool("MoveUp", true);
			anim.SetBool("MoveDown", false);
			anim.SetBool("MoveLeft", false);
			anim.SetBool("MoveRight", false);
		}
		else if(Input.GetKeyUp(KeyCode.W)){
			anim.SetBool("MoveUp", false);
		}
		
		else if(Input.GetKey(KeyCode.S)){
			kimi.Translate(-Vector3.up * speed);
			anim.SetBool("MoveUp", false);
			anim.SetBool("MoveDown", true);
			anim.SetBool("MoveLeft", false);
			anim.SetBool("MoveRight", false);	
		}
		else if(Input.GetKeyUp(KeyCode.S)){
			anim.SetBool("MoveDown", false);
		}

		else if(Input.GetKey(KeyCode.D)){
			kimi.Translate(Vector3.right * speed);
			anim.SetBool("MoveUp", false);
			anim.SetBool("MoveDown", false);
			anim.SetBool("MoveLeft", false);
			anim.SetBool("MoveRight", true);
		}
		else if(Input.GetKeyUp(KeyCode.D)){
			anim.SetBool("MoveRight", false);
		}

		else if(Input.GetKey(KeyCode.A)){
			kimi.Translate(-Vector3.right * speed);
			anim.SetBool("MoveUp", false);
			anim.SetBool("MoveDown", false);
			anim.SetBool("MoveLeft", true);
			anim.SetBool("MoveRight", false);
		}
		else if(Input.GetKeyUp(KeyCode.A)){
			anim.SetBool("MoveLeft", false);
		}
	}

	void OnCollisionEnter2D(Collision2D obj){
		if(obj.gameObject.tag == "Finish"){
			anim.SetBool("Win", true);
			return;
		}
		
		if(obj.gameObject.tag == "enemy"){
			//Debug.Log("Collision!", null);
			anim.SetBool("GameOver", true);
			//SceneManager.LoadScene("MainGame");
		}
	}
}
