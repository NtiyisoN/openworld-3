using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ProjectileCollider : MonoBehaviour {
	


		void OnTriggerEnter(Collider other) 
		{
			if (other.gameObject.CompareTag ( "Pick Up"))
			{	
				
				other.gameObject.SetActive (false);
			}
		}			
	}