using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class unlockLevels : MonoBehaviour
{

	public GameObject _savingSysthem;

	public GameObject _buttonLvl1;
	public GameObject _buttonLvl2;
	public GameObject _buttonLvl3;
	public GameObject _buttonLvl4;
	public GameObject _buttonLvl5;
	public GameObject _buttonLvl6;
	public GameObject _buttonLvl7;
	public GameObject _buttonLvl8;

	void Start ()
	{
		_savingSysthem = GameObject.Find ("SavingSysthem");


		_buttonLvl1 = GameObject.Find ("1");
		_buttonLvl2 = GameObject.Find ("2");
		_buttonLvl3 = GameObject.Find ("3");
		_buttonLvl4 = GameObject.Find ("4");
		_buttonLvl5 = GameObject.Find ("5");
		_buttonLvl6 = GameObject.Find ("6");
		_buttonLvl7 = GameObject.Find ("7");
		_buttonLvl8 = GameObject.Find ("8");


		if (_savingSysthem.GetComponent<savingSysthem> ()._lvl1 == true) {
			_buttonLvl1.GetComponent<Button> ().interactable = true;
		}
		if (_savingSysthem.GetComponent<savingSysthem> ()._lvl2 == true) {
			_buttonLvl2.GetComponent<Button> ().interactable = true;
		}
		if (_savingSysthem.GetComponent<savingSysthem> ()._lvl3 == true) {
			_buttonLvl3.GetComponent<Button> ().interactable = true;
		}
		if (_savingSysthem.GetComponent<savingSysthem> ()._lvl4 == true) {
			_buttonLvl4.GetComponent<Button> ().interactable = true;
		}
		if (_savingSysthem.GetComponent<savingSysthem> ()._lvl5 == true) {
			_buttonLvl5.GetComponent<Button> ().interactable = true;
		}
		if (_savingSysthem.GetComponent<savingSysthem> ()._lvl6 == true) {
			_buttonLvl6.GetComponent<Button> ().interactable = true;
		}
		if (_savingSysthem.GetComponent<savingSysthem> ()._lvl7 == true) {
			_buttonLvl7.GetComponent<Button> ().interactable = true;
		}
		if (_savingSysthem.GetComponent<savingSysthem> ()._lvl8 == true) {
			_buttonLvl8.GetComponent<Button> ().interactable = true;
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
