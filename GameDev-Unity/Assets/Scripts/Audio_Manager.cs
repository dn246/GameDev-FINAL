using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Audio_Manager : MonoBehaviour {

	public AudioMixerSnapshot[] AudioSnapshots;
	public float snapshotblend = 0.5f;


	public AudioSource[] atmosphere;



	void start(){
		(atmosphere [0]).PlayDelayed (1);
		(atmosphere [1]).PlayDelayed (5);
	
	}

	void update(){
		Debug.Log ( (atmosphere [0]).isPlaying );
	
	}


	public void FootstepReverbOn(){
		(AudioSnapshots[0]).TransitionTo (snapshotblend);
	
	}
	public void FootstepReverbOff(){
		(AudioSnapshots [1]).TransitionTo (snapshotblend);

	}

}
