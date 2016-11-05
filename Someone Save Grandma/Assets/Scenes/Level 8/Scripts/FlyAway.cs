using UnityEngine;
using System.Collections;

public class FlyAway : MonoBehaviour {

    public float speed;
    public float radius_x;
    public float radius_z;
	public double startTime;
    private Rigidbody rb;
    private float rand;
	private double tick;
	void Start () {
        rb = GetComponent<Rigidbody>();
        rand = 0;
		tick = 0;
	}
	
	
	void FixedUpdate () {
		
		if (tick > startTime){
			float x = 0.01f * radius_x * Mathf.Cos(rand);
			float z = 0.01f * radius_z * Mathf.Sin(rand);
			rand= rand+ 0.01f;
			Vector3 movement = new Vector3(x, 0.01f*speed, z);
			rb.position=rb.position + movement;
		}
		tick += 1;
        
	}
}
