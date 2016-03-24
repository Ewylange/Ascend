using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{

	public GameObject _savingSysthem;
	
	void Start ()
	{
		_savingSysthem = GameObject.Find ("SavingSysthem");
		_savingSysthem.GetComponent<savingSysthem> ()._coinsNumber += _savingSysthem.GetComponent<savingSysthem> ()._actualLevelCoin;
	}
	
	// Update is called once per frame
	void Update ()
	{
		this.GetComponent<Text> ().text = "Total coins: " + _savingSysthem.GetComponent<savingSysthem> ()._actualLevelCoin;
	}
}
