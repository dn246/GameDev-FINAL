using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_collision_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Player") {
			Destroy(gameObject);

		}

	}

	
	// Update is called once per frame
	void Update () {
		
	}


}
