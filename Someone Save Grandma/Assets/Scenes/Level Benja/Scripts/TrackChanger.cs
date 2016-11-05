using UnityEngine;
using System.Collections;

public class TrackChanger : MonoBehaviour {
	public bool activated=false;
	public Light luz;
	// Use this for initialization
	void Start () {

	}
	
	void OnTriggerEnter(Collider other) {
		if (other.name == "brazo"){
			activated = true;
			luz.enabled=true;
		}
		Debug.Log (other.name);
		Debug.Log (activated);
	}
	void OnTriggerExit(Collider other) {
		if (other.name == "brazo"){
			activated = false;
			luz.enabled=false;
		}
		Debug.Log (other.name);
		Debug.Log (activated);
	}

}
