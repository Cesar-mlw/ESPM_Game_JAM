using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderTrigger : MonoBehaviour {
	public GameManager gameManager;
	public Rigidbody rb;

	public BoxCollider b;

	public BoxCollider b2;


	void Start(){
		rb = GetComponent<Rigidbody>();
			b = GetComponent<BoxCollider>();
	}
	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player"){
			b.enabled = !b.enabled;
			gameManager.AttatchSpider(rb);
		}
	}
}
