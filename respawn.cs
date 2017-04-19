using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour {
	private Vector3 startPos;
	private Quaternion startRot;
	public bool die;
	private Animator myAnimator;

	// Use this for initialization
	void Start () {
		// call the animator
		myAnimator = GetComponent<Animator>();
		
		// make the variables the current position of the object this script is on
		startPos = transform.position;
		startRot = transform.rotation;

	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator wait(){
		//make it so you dont respawn before 3 seconds are over so the death animation can play
		yield return new WaitForSeconds (3f);
		transform.position = startPos ;
		transform.rotation = startRot;
		myAnimator.SetBool ("die", false);
	}

	void OnTriggerEnter(Collider col){
		// if you die / if you collide with the tag death
		if (col.tag == "death") {
			//setting animator variables
			myAnimator.SetBool ("die", true);
			StartCoroutine (wait ()); // use the function i made above this void
			// respawn the player in the right place
			GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, 0f); 
			GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0f, 0f, 0f);

		}
	}

}
