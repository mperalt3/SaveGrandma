using UnityEngine;
using System.Collections;

public class GrandmaMovement : MonoBehaviour {

	//Set initial movement;
	public float MoveSpeed;
	public int MoveDirection = 1;

	//Count time passed
	float timePassed = 0f;

	// Use this for initialization
	void Start () {
		//Set initial speed
		MoveSpeed = Random.Range(1f,2f);
	}

	// Update is called once per frame
	void Update () {

		timePassed += Time.deltaTime;

		if (timePassed > 2) {
			transform.Translate (Vector3.left * MoveSpeed * Time.deltaTime * MoveDirection);
		}
	}

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.tag == "Car")
		{
			MoveSpeed = 0;
		}
	}
}
