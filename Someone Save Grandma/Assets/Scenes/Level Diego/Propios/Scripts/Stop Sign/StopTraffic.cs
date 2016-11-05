using UnityEngine;
using System.Collections;

public class StopTraffic : MonoBehaviour {

	//if player si holding the sign
	public bool active = true;

	//define angle threshold
	public float angleThresh = 30;

	//Transform component
	Transform Trans;

	//Car list
	public GameObject Cars;
	public CarMovement[] carList; 


	// Use this for initialization
	void Start () {
	
		//Get transform component
		Trans = GetComponent<Transform>();

		//Get all Cars
		carList = Cars.GetComponentsInChildren<CarMovement>();

	}
	
	// Update is called once per frame
	void Update () {
		//First check if its active

		//print (Trans.eulerAngles.x);
		//print (Trans.eulerAngles.y);
		//print (Trans.eulerAngles.z);


		if (active == true) {
			if ((Trans.eulerAngles.y <= (270 + angleThresh) && Trans.eulerAngles.y >= (270 - angleThresh) || Trans.eulerAngles.y <= (90 + angleThresh) && Trans.eulerAngles.y >= (90 - angleThresh)) && (Trans.eulerAngles.z <= (angleThresh) || Trans.eulerAngles.z >= (360 - angleThresh)) && (Trans.eulerAngles.x <= angleThresh || Trans.eulerAngles.x >= (360 - angleThresh) || Trans.eulerAngles.x <= (180 + angleThresh) && Trans.eulerAngles.x >= (180 - angleThresh))) {
				//print ("stoping");
				foreach (CarMovement car in carList) {
					car.CarBrake ();
				}

			} else {
				foreach (CarMovement car in carList) {
					car.CarAccelerate ();
				}
			}
		}
	}


	//Stops car traffic once its facing traffic
	void StopCars(){

	}
}
