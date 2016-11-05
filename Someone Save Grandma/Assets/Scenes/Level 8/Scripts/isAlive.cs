using UnityEngine;
using System.Collections;

public class isAlive : MonoBehaviour {

    public bool alive;
    public bool hasFlown;
    public bool hasFallen;
	public double maxHeight;
    private Vector3 initialRotation;
	private Animator anim;
    private Rigidbody rb;

    void Start () {
        initialRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        alive = true;
        hasFlown = false;
        hasFallen = false;
		anim = GetComponent<Animator> ();
		anim.SetBool ("isHanging",true);
        rb = GetComponent<Rigidbody>();
}

	void FixedUpdate () {
        if (!hasFlown && transform.position.y > 0.5)
        {
            hasFlown = true;
        }
	    if (transform.position.y > maxHeight)
        {
            alive = false;
        }

	}

    private void OnCollisionEnter(Collision collision)
    {
        if (hasFlown && !hasFallen)
        {
            if (collision.collider.name.Contains("Tile") || collision.collider.name.Contains("road"))
            {
                hasFallen = true;
                if (alive)
                {
                    Debug.Log("Cai pero vivo");
                    //anim.SetTrigger("hitTheGroundAndLive");
                    gettingBodyUp(collision.collider);
                    anim.SetTrigger("gettingUp");
                }
                else
                {
                    Debug.Log("Cai y estoy muerta");
                    anim.SetTrigger("hitTheGroundAndDie");
                }
            }
        }
    }

    private void gettingBodyUp(Collider collider)
    {
        //new WaitForSeconds(5f);
        Quaternion rotation = Quaternion.Euler(initialRotation.x, initialRotation.y+180, initialRotation.z);
        rb.MoveRotation(rotation);
    }
}
