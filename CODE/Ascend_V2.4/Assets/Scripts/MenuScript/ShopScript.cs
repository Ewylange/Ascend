using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{

	public GameObject _savingSysthem;
	public GameObject _HowMuchCoins;
	
	void Start ()
	{
		_savingSysthem = GameObject.Find ("SavingSysthem");
		_HowMuchCoins = GameObject.Find ("HowMuchCoins");
	}
	
	// Update is called once per frame
	void Update ()
	{
		_HowMuchCoins.GetComponent<Text> ().text = "Coins " + _savingSysthem.GetComponent<savingSysthem> ()._coinsNumber;
	}

	public void buySkin1 ()
	{
		if ((_savingSysthem.GetComponent<savingSysthem> ()._coinsNumber - 5) >= 0) {
			_savingSysthem.GetComponent<savingSysthem> ()._coinsNumber -= 5;
			_savingSysthem.GetComponent<savingSysthem> ().Save ();
		}
	}
}
