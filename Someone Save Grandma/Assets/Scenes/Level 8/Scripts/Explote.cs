using UnityEngine;
using System.Collections;

public class Explote : MonoBehaviour {


    void Start () {
		GetComponent<Rigidbody>().collisionDetectionMode = CollisionDetectionMode.Continuous;
	}

	private void OnTriggerEnter(Collider collider)
	{
		var collisionForce = GetCollisionForce(collider);

		if (collisionForce > 0)
		{
			ExplodeBalloon(collisionForce);
		}
	}

	private float GetCollisionForce(Collider collider)
	{
		/*if ((collision.collider.name.Contains("Sword") && collision.collider.GetComponent<Sword>().CollisionForce() > breakForce))
		{
			return collision.collider.GetComponent<Sword>().CollisionForce() * 1.2f;
		}
		*/
		if (collider.name.Contains("Arrow"))
		{
			return 500f;
		}

		return 0f;
	}

	private void ExplodeBalloon(float force)
	{
		/*foreach (Transform face in GetComponentsInChildren<Transform>())
		{
			if (face.transform.name == transform.name) continue;
			ExplodeFace(face, force);
		}*/
        
		Destroy(gameObject);
		//gameObject.SetActive (false);
	}

	/*
	private void ExplodeFace(Transform face, float force)
	{
		face.transform.parent = null;
		Rigidbody rb = face.gameObject.AddComponent<Rigidbody>();
		rb.isKinematic = false;
		rb.useGravity = true;
		rb.AddExplosionForce(force, Vector3.zero, 0f);
		Destroy(face.gameObject, 10f);
	} */
}
