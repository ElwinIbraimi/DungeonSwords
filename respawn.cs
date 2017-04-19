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

		startPos = transform.position;
		startRot = transform.rotation;

	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator wait(){
		print ("BOI FIX YO SHIT");
		yield return new WaitForSeconds (3f);
		transform.position = startPos ;
		transform.rotation = startRot;
		myAnimator.SetBool ("die", false);
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "death") {
			//setting animator variables
			myAnimator.SetBool ("die", true);
			StartCoroutine (wait ());
			GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, 0f);
			GetComponent<Rigidbody> ().angularVelocity = new Vector3 (0f, 0f, 0f);

		}
	}

}
