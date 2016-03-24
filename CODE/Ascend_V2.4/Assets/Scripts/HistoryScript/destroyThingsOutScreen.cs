using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Ce script se met sur la barre du bas et detruit tout les objets qu'elle traverse.
public class destroyThingsOutScreen : MonoBehaviour 
{

	void OnTriggerExit(Collider col)
	{
		if(col.gameObject.name == "Gaz block")
		{
			Destroy(col.gameObject);
		}

		if(col.gameObject.name == "Spikes")
		{
			Destroy(col.gameObject);
		}

		if(col.gameObject.name == "icyBlock")
		{
			Destroy(col.gameObject);
		}

		if(col.gameObject.name == "Stone blocks")
		{
			Destroy(col.gameObject);
		}
	}
}
