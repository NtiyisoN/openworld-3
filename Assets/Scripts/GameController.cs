using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	// joueur
	public GameObject joueur;
	private int nbCochons;
	private int niveauActuel;

	// intro
	public Camera introCamera;
	 
	// canvas
	public GameObject canvasIntro;
	public GameObject canvasGui;
	public Text texteNbCochons;
	public GameObject canvasVictoire;
	public GameObject canvasGameOver;

	// iles
	public GameObject ile2;

	void Start () {
		introCamera.enabled = true;
		cacherTousLesCanvas ();
		canvasIntro.SetActive (true);
		//canvasVictoire.SetActive (true);
		//Debug.Log(canvasVictoire.GetComponent());
		joueur.SetActive (false);
	}

	void Update () {
		// si on tombe dans l'eau => game over
		if (joueur.transform.position.y < 3) {
			gameOver();
		}
	}

	public void Jouer(){
		Debug.Log ("Jouer");
		niveauActuel = 0;
		prochainNiveau ();
		introToJoueur();
	}

	public void prochainNiveau(){
		niveauActuel++;
		if (niveauActuel == 1) {
			niveau1 ();
		} else if (niveauActuel == 2) {
			niveau2 ();
		} else {
			victoire ();
		}
	}

	private void niveau1(){
		Debug.Log ("niveau 1");
		Vector3 newPos = new Vector3(215f,10f,200f);
		joueur.transform.position = newPos;
		nbCochons = 3;
		actualiserNbCochonsGui ();
	}

	private void niveau2(){
		Debug.Log ("niveau 2");
		nbCochons = 10;
		actualiserNbCochonsGui ();
		Vector3 newPos = new Vector3(1021.39f,24.0f,386.49f);
		joueur.transform.position = newPos;
		joueur.transform.eulerAngles = new Vector3(0, -75f, 0);
		Vector3 newPosIle = new Vector3(697f,-39f,281.7f);
		ile2.transform.position = newPosIle;

	}

	public void victoire() {
		joueurToIntro ();
		canvasVictoire.SetActive (true);
	}

	public void gameOver(){
		joueurToIntro ();
		canvasGameOver.SetActive (true);
	}

	public void Quitter() {
		Debug.Log ("Quitter");
		Application.Quit ();
	}

	private void cacherTousLesCanvas() {
		canvasGui.SetActive (false);
		canvasIntro.SetActive (false);
		canvasVictoire.SetActive (false);
		canvasGameOver.SetActive (false);
	}

	private void joueurToIntro(){
		cacherTousLesCanvas ();
		canvasIntro.SetActive (true);
		introCamera.enabled = true;
		joueur.SetActive (false);
	}

	private void introToJoueur(){
		cacherTousLesCanvas ();
		canvasGui.SetActive (true);
		introCamera.enabled = false;
		joueur.SetActive (true);
		texteNbCochons.text = ""+nbCochons;
	}

	public bool demandeDeTir() {
		Debug.Log ("demande de tir : " + nbCochons);
		if (nbCochons >= 1) {
			nbCochons--;
			actualiserNbCochonsGui ();
			return true;
		} else {
			gameOver ();
			return false;
		}
	}

	private void actualiserNbCochonsGui(){
		texteNbCochons.text = ""+nbCochons;
	}
}
