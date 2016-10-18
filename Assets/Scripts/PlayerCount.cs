using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCount : MonoBehaviour {


	public Text countText;
	public Text winText;

	private int count;

	// Use this for initialization
	void Start () {
		
		count = 0;
		SetCountText ();
		winText.text = "";
	
	}
	
	// Update is called once per frame
	void Update () {
		
		SetCountText ();
	
	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= GameObject.FindGameObjectsWithTag("Pick Up").Length)
		{
			winText.text = "You Win!";
		}
	}

	void setCount(int counts)
	{
		count = count+counts;
	}
}
