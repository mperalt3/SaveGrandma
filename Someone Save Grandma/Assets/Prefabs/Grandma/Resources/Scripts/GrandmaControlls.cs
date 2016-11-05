using UnityEngine;
using System.Collections;

public class GrandmaControlls : MonoBehaviour {
	public bool isWalking;
	public float speed = 10;
	public float rotationSpeed = 100;

	static Animator anim;

	public enum MovementStates{
		Idle,
		Walking,
		Falling,
		Landing,
		HangingRope
	}

	public MovementStates MovementTypes;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed;
		float rotation = Input.GetAxis ("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Rotate (0, rotation, 0);
		if (translation != 0) {
			anim.SetBool ("isWalking", true);
		} else {
			anim.SetBool ("isWalking", false);
		}
	}

}
