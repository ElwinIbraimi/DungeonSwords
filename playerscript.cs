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
		//if you press LMB or Left CTRL
		if (Input.GetAxis ("Fire1") != 0) {
			melee = true; // the boolean melee will be true
		}
		// if you release LMB or Left Ctrl
		if (Input.GetAxis ("Fire1") == 0) {
			melee = false; // the boolean melee will turn false again.
		}
		//if you press RMB
		if (Input.GetAxis ("Fire2") != 0) {
			block = true; // boolean block will be true
		}
		// if you release RMB
		if (Input.GetAxis ("Fire2") == 0) {
			block = false; // boolean block will be false
		}

	}
}
