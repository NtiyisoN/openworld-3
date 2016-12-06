using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerCount : MonoBehaviour {


	public Text countText;
	public Text winText;
	public GameObject player;

	private int count;

	// Use this for initialization
	void Start () {
		
		player = GameObject.FindGameObjectWithTag("Player");
		count = 0;
		SetCountText ();
		winText.text = "";

	}

	// Update is called once per frame
	void Update () {

		SetCountText ();
		if(player.transform.position.y < 2)
		{ 
			winText.text = "Game Over";

		}

	}

	void SetCountText ()
	{
		countText.text = "Count: " + count.ToString ();
		if (GameObject.FindGameObjectsWithTag("Pick Up").Length <= 0)
		{
			winText.text = "You Win!";
		}
	}

	public void addCount(){
		count++;
	}

	void setCount(int counts)
	{
		count = count+counts;
	}
}
