using UnityEngine;
using UnityEngine.Audio;
using System.Collections;

public class AudioZone : MonoBehaviour {

	public AudioMixerSnapshot[] snapshotsToTransitionTo;
	public float transitionTime;

	public Footsteps footstepController;
	public AudioClip[] footsteps;

	void OnTriggerEnter() {
		foreach( AudioMixerSnapshot snapshot in snapshotsToTransitionTo ) {
			snapshot.TransitionTo( transitionTime );
		}

		if( footstepController ) {
			footstepController.clips = this.footsteps;
		}
	}
}
