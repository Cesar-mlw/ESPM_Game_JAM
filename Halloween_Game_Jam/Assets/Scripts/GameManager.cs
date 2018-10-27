using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public GameObject player;
	public GameObject[] spiders;
	public void AttatchSpider(Rigidbody rb){
		player.AddComponent<FixedJoint>();
		player.GetComponent<FixedJoint>().connectedBody = rb;
	}
}
