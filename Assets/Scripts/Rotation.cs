using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float vitesseX;
	public float vitesseY;
	public float vitesseZ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (vitesseX,vitesseY,vitesseZ) * Time.deltaTime);
	}
}
