using UnityEngine;
using System.Collections;

public class playerscript : MonoBehaviour {

	private Animator myAnimator;
	public bool melee;
	public bool block;

	// Use this for initialization
	void Start () {
	// call the animator
		myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		//setting animator variables
		myAnimator.SetBool ("melee", melee);
		myAnimator.SetBool ("block", block);

		if (Input.GetAxis ("Fire1") != 0) {
			melee = true;
		}
		if (Input.GetAxis ("Fire1") == 0) {
			melee = false;
		}
		if (Input.GetAxis ("Fire2") != 0) {
			block = true;
		}
		if (Input.GetAxis ("Fire2") == 0) {
			block = false;
		}

	}
}
