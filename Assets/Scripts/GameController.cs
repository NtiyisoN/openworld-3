using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject joueur;
	public Camera introCamera;
	public GameObject canvasIntro;
	public GameObject ile2;

	private int niveauActuel = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// si on tombe dans l'eau, on recommencele niveau
		if (joueur.transform.position.y < 2) {
			niveauActuel--;
			prochainNiveau();
		}
	}

	public void Jouer(){
		Debug.Log ("Jouer");
		prochainNiveau ();
		introCamera.enabled = false;
		canvasIntro.SetActive (false);
		joueur.SetActive (true);

	}

	public void prochainNiveau(){
		niveauActuel++;
		if (niveauActuel == 1) {
			niveau1 ();
		} else if (niveauActuel == 2) {
			niveau2 ();
		} else if (niveauActuel == 3) {
			niveau3 ();
		} else {
			victoire ();
		}
	}

	private void niveau1(){
		Debug.Log ("niveau 1");
		Vector3 newPos = new Vector3(215f,10f,200f);
		joueur.transform.position = newPos;
	}

	private void niveau2(){
		Debug.Log ("niveau 2");
		Vector3 newPos = new Vector3(1021.39f,24.0f,386.49f);
		joueur.transform.position = newPos;
		joueur.transform.eulerAngles = new Vector3(0, -75f, 0);
		Vector3 newPosIle = new Vector3(697f,-39f,281.7f);
		ile2.transform.position = newPosIle;
	}

	private void niveau3(){

	}

	private void victoire() {

	}

	public void Quitter() {
		Debug.Log ("Quitter");
		Application.Quit ();
	}
}
