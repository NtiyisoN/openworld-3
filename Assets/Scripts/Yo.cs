using UnityEngine;
using System.Collections;

public class Yo : MonoBehaviour {

	public Rigidbody projectile;
	public Transform Spawnpoint;

	private Camera camera;
	private GameObject player;

	// Use this for initialization
	void Start () {
		 camera = GetComponentInChildren<Camera> ();
		 player = this.gameObject;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			Debug.Log("FIRE");

			// création du projectile
			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, Spawnpoint.position, Spawnpoint.rotation);
			clone.transform.Translate(Vector3.right * Time.deltaTime * 130);
			clone.GetComponent<Renderer> ().material.color = new Color (1, 0, 0);
			// ignore
			Physics.IgnoreCollision(clone.GetComponent<Collider>(), player.GetComponent<Collider>());
			// shoot
			float shootForce = 1000;
			clone.GetComponent<Rigidbody>().AddForce(clone.transform.forward * shootForce);
		}

		// Debug.Log(camera.transform.eulerAngles.y);
		// Debug.Log("rotation.y(" + camera.transform.rotation.y + ") eulerAngles.y("+camera.transform.eulerAngles.y+")");
	}
}
