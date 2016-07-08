using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {

	public NavMeshAgent agent;
	public AudioSource footstepsSource;
	public AudioClip[] clips;
	public float footstepInterval = 0.5f;

	int lastFootstep = -1;

	public void Start() {
		StartCoroutine( PlayFootsteps() );
	}

	IEnumerator PlayFootsteps() {
		while( enabled ) {
			if( agent.velocity.magnitude > agent.speed / 2f ) {
				int randomFootstep = lastFootstep;
				while( randomFootstep == lastFootstep ) {
					randomFootstep = Random.Range( 0, clips.Length );
				}

				footstepsSource.clip = clips[randomFootstep];
				footstepsSource.Play();
			}

			yield return new WaitForSeconds( footstepInterval );
		}
	}
}
