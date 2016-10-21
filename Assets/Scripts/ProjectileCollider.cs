using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProjectileCollider : MonoBehaviour {

	private GameObject player;

		void Start ()
		{
			player = GameObject.FindGameObjectsWithTag ("Player")[0];
		}

		void OnTriggerEnter(Collider other)
		{
			if (other.gameObject.CompareTag ( "Pick Up"))
			{
				other.gameObject.SetActive (false);
				PlayerCount playerCount = player.GetComponent<PlayerCount>();
				Debug.Log(playerCount);
				playerCount.addCount();
			}
		}
	}
