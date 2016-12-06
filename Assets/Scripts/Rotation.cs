using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float vitesseX;
	private float vitesseXCalculee;
	public float angleXMin;
	public float angleXMax;
	public float vitesseY;
	private float vitesseYCalculee;
	public float angleYMin;
	public float angleYMax;
	public float vitesseZ;
	private float vitesseZCalculee;
	public float angleZMin;
	public float angleZMax;

	// Use this for initialization
	void Start () {
		vitesseXCalculee = vitesseX;
		vitesseYCalculee = vitesseY;
		vitesseZCalculee = vitesseZ;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3 (vitesseXCalculee,vitesseYCalculee,vitesseZCalculee) * Time.deltaTime);
	}

	void FixedUpdate() {
		// X
		if (Mathf.Abs (vitesseX) != 0) {
			if (angleXMin != 0 && this.transform.rotation.x <= angleXMin)
				vitesseXCalculee = vitesseX;
			else if (angleYMin != 0 && this.transform.rotation.x >= angleXMax)
				vitesseXCalculee = -vitesseX;
		}

		// Y
		if (Mathf.Abs (vitesseY) != 0) {
			if (angleYMin != 0 && this.transform.eulerAngles.y <= angleYMin)
				vitesseYCalculee = vitesseY;
			else if (angleYMax != 0 && this.transform.eulerAngles.y >= angleYMax)
				vitesseYCalculee = -vitesseY;
		}

		// Z
		if (Mathf.Abs (vitesseZ) != 0) {
			if (angleZMin != 0 && this.transform.eulerAngles.z <= angleZMin)
				vitesseZCalculee = vitesseZ;
			else if (angleZMax != 0 && this.transform.eulerAngles.z >= angleZMax)
				vitesseZCalculee = -vitesseZ;
		}

	}
}
