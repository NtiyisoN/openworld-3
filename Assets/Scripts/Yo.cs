using UnityEngine;
using System.Collections;

public class Yo : MonoBehaviour {

	public Rigidbody projectile;
	public Transform Spawnpoint;
	public GameController gameController;

	private GameObject player;

	// Use this for initialization
	void Start () {
		 player = this.gameObject;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			if (gameController.demandeDeTir ()) {
				// création du projectile
				Rigidbody clone;
				clone = (Rigidbody)Instantiate (projectile, Spawnpoint.position, Spawnpoint.rotation);
				clone.transform.Translate (Vector3.right * Time.deltaTime * 130);
				clone.GetComponent<Renderer> ().material.color = new Color (1, 0, 0);
				// ignore collision avec le player
				Physics.IgnoreCollision (clone.GetComponent<Collider> (), player.GetComponent<Collider> ());
				// tir
				float shootForce = 1000;
				clone.GetComponent<Rigidbody> ().AddForce (clone.transform.forward * shootForce);
			}
		}
	}
}
