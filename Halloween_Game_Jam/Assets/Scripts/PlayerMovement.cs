using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Transform FirePoint;
	public float jetpackForce = 0f;

	Rigidbody rb;

	void Start(){
		rb = GetComponent<Rigidbody>();
	}

	private void FixedUpdate() {
		if(Input.GetKey(KeyCode.LeftControl)){
			jetpackForce += 0.8f;
			
			Shoot(jetpackForce);
		}
		else{
			if(jetpackForce - 0.5f >= 0f){
				jetpackForce -= 0.5f; 
			}
			else{
				jetpackForce = 0f;
			}
		}
			Rotate();
		
	}

	void Shoot(float jetpackForce){
		rb.AddRelativeForce(0, 0,  - (rb.transform.localPosition.z - jetpackForce) * Time.deltaTime, ForceMode.Impulse);
	}

	void Rotate(){
		float h = 2f * Input.GetAxis("Mouse X");

		rb.transform.Rotate(h, 0, 0);
	}
}
