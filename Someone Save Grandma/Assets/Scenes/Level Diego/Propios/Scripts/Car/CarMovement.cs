using UnityEngine;
using System.Collections;

public class CarMovement : MonoBehaviour {

	public float MoveSpeed;
	public float initialMoveSpeed;
	public int MoveDirection = -1;

	//Definir delta time y time
	public float t;
	public float timePassed = 0;

	//Rigidbody component
	Rigidbody RBCar;
	float carMass;

	//Braking power
	public float BrakingPower = 0;

	// Use this for initialization
	void Start () {
		//Set initial speed
		MoveSpeed = Random.Range(4f,8f);
		initialMoveSpeed = MoveSpeed;

		//Get Rigidbody Component
		RBCar = GetComponent<Rigidbody>();

		//Obtain Car Mass
		carMass = RBCar.mass;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime * MoveDirection);

		timePassed += Time.deltaTime;

		//Define delta time into a variable t
		t = Time.deltaTime;

		//Brake the car after 2 seconds
		if (timePassed > 2){
			
			//Debug.Log (t);

		}
	}

	//Brake the car when sign is up
	public void CarBrake () {
		//print("Braking");
		//print (MoveSpeed);
		if (MoveSpeed > 0.5f) {
			MoveSpeed = MoveSpeed - t * 10*(BrakingPower/carMass);
		} else {
			MoveSpeed = 0;
		}
	}

	//Brake the car when sign is up
	public void CarAccelerate () {
		if (MoveSpeed < initialMoveSpeed ) {
			MoveSpeed = MoveSpeed + t * 10*(BrakingPower/carMass);
		} else {
			MoveSpeed = initialMoveSpeed;
		}
	}
}
