using UnityEngine;
using System.Collections;

public class initialisationIle2 : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public GameObject Ile2;
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		Ile2 = GameObject.FindGameObjectWithTag("Ile2");

	}

	// Update is called once per frame
	void Update () {

		if(player.transform.position.y < 2)
		{ 
			Vector3 newPos = new Vector3(1021.39f,24.0f,386.49f);
			player.transform.position = newPos;
			Vector3 newPosIle = new Vector3(697f,-39f,281.7f);
			Ile2.transform.position = newPosIle;
		}

	}
}
