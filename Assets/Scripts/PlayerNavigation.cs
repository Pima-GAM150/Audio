using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PlayerNavigation : MonoBehaviour, IPointerClickHandler {

	public NavMeshAgent playerAgent;

	public void OnPointerClick( PointerEventData evt ) {
		Vector3 worldPos = evt.pointerPressRaycast.worldPosition;

		playerAgent.SetDestination( worldPos );
	}
}
