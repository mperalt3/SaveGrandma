using UnityEngine;
using System.Collections;

public class LookForGrandma : MonoBehaviour {

    public GameObject grandma;

    void Start () {
	
	}
	
	void LateUpdate () {
        transform.LookAt(grandma.transform);
	}
}
