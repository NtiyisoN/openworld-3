using UnityEngine;
using System.Collections;

public class Yo : MonoBehaviour {

	public Rigidbody projectile;
	public Transform Spawnpoint;

	private Camera camera;

	// Use this for initialization
	void Start () {
		 Debug.Log ("Hello", gameObject);
		 camera = GetComponentInChildren<Camera> ();
		 Debug.Log(camera);
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			Debug.Log("FIRE");

			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, projectile.rotation);

			clone.velocity = Spawnpoint.TransformDirection (Vector3.forward*20);
		}

		// Debug.Log(camera.transform.eulerAngles.y);
		// Debug.Log("rotation.y(" + camera.transform.rotation.y + ") eulerAngles.y("+camera.transform.eulerAngles.y+")");
	}
}
