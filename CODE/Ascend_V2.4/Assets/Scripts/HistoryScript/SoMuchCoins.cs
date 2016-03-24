using UnityEngine;
using System.Collections;


//Ceci est le score des coins elle est appliquee au player et 
//consiste a recolter des coins qui augmente un score.
public class SoMuchCoins : MonoBehaviour
{

	public int totalScoring = 0;
	//La valeur de la coin peut se modifier sur unity
	public int coinValue = 2;

	public GameObject _savingSysthem;
	
	void Start ()
	{
		_savingSysthem = GameObject.Find ("SavingSysthem");
	}

	//=================================================================================================================================================
	// Update is called once per frame
	void Update ()
	{
		//Debug.Log ("coins: " + totalScoring);
	}
	//=================================================================================================================================================

	//=================================================================================================================================================
	void OnTriggerEnter (Collider collision)
	{
		if (collision.gameObject.name == "Coin") {
			Destroy (collision.gameObject);
			totalScoring += coinValue;
			//_savingSysthem.GetComponent<savingSysthem> ()._coinsNumber += coinValue;
			_savingSysthem.GetComponent<savingSysthem> ()._actualLevelCoin = totalScoring;
		}
	}
	//=================================================================================================================================================
}
