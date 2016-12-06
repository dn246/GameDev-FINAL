using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_text : MonoBehaviour {

	public GameObject sample_text_1;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "dialogue_1") {
			Instantiate (sample_text_1, gameObject.transform.position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
