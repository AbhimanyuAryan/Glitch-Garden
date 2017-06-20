using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Attacker))] public class Fox : MonoBehaviour {

	public Animator anim;
	private Attacker attacker;

	void Start () {
		anim = GetComponent<Animator>();
		attacker = GetComponent<Attacker>();
	}

	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log("Fox collided with " + collider);
		GameObject obj = collider.gameObject;

		if(!obj.GetComponent<Defender>()){
			return;
		}
		Debug.Log("Fox collided with " + collider);

		if(obj.GetComponent<Stone>()){
			anim.SetTrigger("jump trigger");
		}else{
			anim.SetBool("isAttacking", true);
			attacker.Attack(obj);

		}
	}
}
