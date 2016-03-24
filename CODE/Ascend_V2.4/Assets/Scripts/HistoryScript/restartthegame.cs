using UnityEngine;
using System.Collections;

public class restartthegame : MonoBehaviour 
{
	//=====================================================================================
	// Ce script est pour restart le jeu rapidement en appuyant sur la barre SPACE
	void Update () 
	{
		//Restart avec SPACE
		if (Input.GetKeyDown (KeyCode.Space))
		{
			Application.LoadLevel(Application.loadedLevel);	
		}
	}
	//=====================================================================================
}
