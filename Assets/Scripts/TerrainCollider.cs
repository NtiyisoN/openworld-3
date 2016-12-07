using UnityEngine;
using System.Collections;

public class TerrainCollider : MonoBehaviour {

	public GameController gameController;

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ( "Target"))
		{
			other.gameObject.SetActive (false);
			gameController.prochainNiveau ();

		}
	}
}
