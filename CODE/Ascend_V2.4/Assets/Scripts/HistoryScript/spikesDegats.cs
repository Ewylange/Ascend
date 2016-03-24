using UnityEngine;
using System.Collections;

//Ceci correspond aux degats des spikes
public class spikesDegats : MonoBehaviour 
{
	//========================================================================================================================
	void OnCollisionExit(Collision collision) 
	{
		if(collision.gameObject.name == "Player")
		{
			collision.gameObject.GetComponent<Life>().life -=1;
		}
	}
	//========================================================================================================================
}
