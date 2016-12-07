using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class Audio_Manager : MonoBehaviour {

	public AudioMixerSnapshot[] AudioSnapshots;
	public float snapshotblend = 0.5f;



	public void FootstepReverbOn(){
		(AudioSnapshots[0]).TransitionTo (snapshotblend);
	
	}
	public void FootstepReverbOff(){
		(AudioSnapshots [1]).TransitionTo (snapshotblend);

	}

}
