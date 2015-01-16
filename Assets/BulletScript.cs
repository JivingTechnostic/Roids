using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public Vector3 thrust;
	public Quaternion heading;

	// Use this for initialization
	void Start () {
	
		thrust.x = 400.0f;
		gameObject.rigidbody.drag = 0;
		gameObject.rigidbody.MoveRotation (heading);
		gameObject.rigidbody.AddRelativeForce (thrust);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter( Collision collision) {
		Collider collider = collision.collider;
		if (collider.CompareTag ("Asteroid")) {
			AsteroidScript roid = collider.gameObject.GetComponent<AsteroidScript>();
			roid.Die();
			Destroy (gameObject);
		} else {
			Debug.Log ("Collided with " +collider.tag);
		}
	}
}
