using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapSwitch : MonoBehaviour {

	public bool button;
	private Animator myAnimator;
	public GameObject gate1;
	public GameObject gate2;
	public float destroyTime;

	void Start () {
		// Call the animator just once at the start
		myAnimator = GetComponent<Animator>();
	}
	// Update is called once per frame
	void Update () {

		// if button is true
		if (button == true){
			Destroy (gate1, destroyTime);
			Destroy (gate2, destroyTime);
		}

		// setting up the variables 
		//myAnimator.SetBool ("trigger", buttonTrigger);
		//myAnimator.SetBool ("exit", buttonExit);
	}
	// if a gameObject with the tag collides with the object this scrip is
	// attached to, the boolean button is true
	void OnTriggerEnter (Collider other){
		if (other.gameObject.tag == "trigger"){
			button = true;
			//GetComponent<Animation>() ["buttonTriggerd"].wrapMode = WrapMode.Once;
			//GetComponent<Animation>().Play ("buttonTriggerd");
		}
	}
	// if the gameobject with the tag trigger exits the the object this scrip is
	// attached to, the boolean button is false
	void OnTriggerExit (Collider other){
			button = false;	
	}
}
