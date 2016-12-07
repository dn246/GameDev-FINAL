using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trigger_collider : MonoBehaviour {


	public Text score_text;

	private float scorecount;


	// Use this for initialization
	void Start () {
		score_text.text = "Score: 0";
		scorecount = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(Collider other){
		if (other.gameObject.tag == "Item") {
			if (Input.GetMouseButtonDown (0)) {

				float item_score = (other.gameObject.GetComponent<Item_trait> ()).item_value;
				scorecount += item_score;
				score_text.text = "Score: " + scorecount;

				Destroy (other.gameObject);
				// add more stuff here with UI/Canvass
			}
		}
	}
	void OnTriggerEnter(Collider other){

		Behaviour[] halos = other. GetComponentsInChildren<Behaviour> ();
		foreach( Behaviour halo in halos)
		{
			halo.enabled = true; 
		}
	}
	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "Item") {
			Behaviour[] halos = other. GetComponentsInChildren<Behaviour> ();
			foreach( Behaviour halo in halos)
			{
				halo.enabled = false; 
			}
		}
	}
}
