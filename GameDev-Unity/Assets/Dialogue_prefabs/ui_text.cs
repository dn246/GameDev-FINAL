using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_text : MonoBehaviour {
/*
	public GameObject intro_text;
	public GameObject question_text;
	public GameObject musket_text;
*/

	public GameObject[] texts;

	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Dialogue_1") {
			Debug.Log ("hi");
		//	Instantiate (intro_text, gameObject.transform.position, Quaternion.identity);
			Instantiate (texts[0], gameObject.transform.position, Quaternion.identity);
		}
		if (collision.gameObject.tag == "Dialogue_2") {
		//	Instantiate (question_text, gameObject.transform.position, Quaternion.identity);
			Instantiate (texts[1], gameObject.transform.position, Quaternion.identity);

		}
		if (collision.gameObject.tag == "Dialogue_3") {
		//	Instantiate (musket_text, gameObject.transform.position, Quaternion.identity);
			Instantiate (texts[2], gameObject.transform.position, Quaternion.identity);
		}
		if (collision.gameObject.tag == "Dialogue_4") {
			//	Instantiate (musket_text, gameObject.transform.position, Quaternion.identity);
			Instantiate (texts [3], gameObject.transform.position, Quaternion.identity);
		}
		if (collision.gameObject.tag == "Dialogue_5") {
			//	Instantiate (musket_text, gameObject.transform.position, Quaternion.identity);
			Instantiate (texts [4], gameObject.transform.position, Quaternion.identity);
		}
		if (collision.gameObject.tag == "Dialogue_6") {
			//	Instantiate (musket_text, gameObject.transform.position, Quaternion.identity);
			Instantiate (texts [5], gameObject.transform.position, Quaternion.identity);
		}
		if (collision.gameObject.tag == "Dialogue_7") {
			//	Instantiate (musket_text, gameObject.transform.position, Quaternion.identity);
			Instantiate (texts [6], gameObject.transform.position, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
