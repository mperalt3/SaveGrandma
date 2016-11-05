using UnityEngine;
using System.Collections;

public class DebugExplote : MonoBehaviour {

    public bool destroy;
	void Start () {
        destroy = false;
	}
	

	void FixedUpdate () {
	    if (destroy)
        {
            Destroy(gameObject);
        }
	}
}
