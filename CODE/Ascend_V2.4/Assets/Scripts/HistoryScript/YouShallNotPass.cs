using UnityEngine;
using System.Collections;

public class YouShallNotPass : MonoBehaviour
{

	//CECI restart le level quand le player sort par le bas

	public GameObject _savingSysthem;
	
	void Start ()
	{
		_savingSysthem = GameObject.Find ("SavingSysthem");
	}

	//========================================================================================================================
	void OnCollisionEnter (Collision col)
	{
		//Si le le joueur touche le bas gameover et restart
		if (col.gameObject.name == "Player") {
			Application.LoadLevel (12);	
			_savingSysthem.GetComponent<savingSysthem> ()._actualLevelCoin = 0;
		}
	}
	//========================================================================================================================
}
