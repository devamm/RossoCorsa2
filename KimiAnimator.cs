using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimiAnimator : MonoBehaviour {
	Transform kimi;

	public float speed;

	void Start () {
		kimi = GameObject.Find("kimi0").GetComponent<Transform> ();

	}

	void Update () {
		if(Input.GetKey(KeyCode.W)){
			kimi.Translate(Vector3.up * speed);
		}
		
		else if(Input.GetKey(KeyCode.S)){
			kimi.Translate(-Vector3.up * speed);
		}

		else if(Input.GetKey(KeyCode.D)){
			kimi.Translate(Vector3.right * speed);
		}

		else if(Input.GetKey(KeyCode.A)){
			kimi.Translate(-Vector3.right * speed);
		}
	}

	void OnCollisionEnter2D(Collision2D obj){
		if(obj.gameObject.tag != "wall"){
			Debug.Log("Collision!", null);
		}
	}
}
