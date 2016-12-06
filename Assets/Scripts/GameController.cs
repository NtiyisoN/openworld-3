using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject fpsController;
	public Camera introCamera;
	public GameObject canvasIntro;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Jouer(){
		introCamera.enabled = false;
		canvasIntro.SetActive (false);
		fpsController.SetActive (true);
	}

	public void Quitter() {
		Debug.Log ("Quitter");
		Application.Quit ();
	}
}
