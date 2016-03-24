using UnityEngine;
using System.Collections;

public class EndLevel : MonoBehaviour
{

	public GameObject _savingSysthem;
	
	void Start ()
	{
		_savingSysthem = GameObject.Find ("SavingSysthem");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.tag == "Player") {
			_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName = Application.loadedLevelName;

			if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level1") {
				_savingSysthem.GetComponent<savingSysthem> ()._lvl2 = true;
				_savingSysthem.GetComponent<savingSysthem> ().Save ();
			}

			if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level2") {
				_savingSysthem.GetComponent<savingSysthem> ()._lvl3 = true;
				_savingSysthem.GetComponent<savingSysthem> ().Save ();
			}

			if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level3") {
				_savingSysthem.GetComponent<savingSysthem> ()._lvl4 = true;
				_savingSysthem.GetComponent<savingSysthem> ().Save ();
			}

			if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level4") {
				_savingSysthem.GetComponent<savingSysthem> ()._lvl5 = true;
				_savingSysthem.GetComponent<savingSysthem> ().Save ();
			}

			if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level5") {
				_savingSysthem.GetComponent<savingSysthem> ()._lvl6 = true;
				_savingSysthem.GetComponent<savingSysthem> ().Save ();
			}

			if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level6") {
				_savingSysthem.GetComponent<savingSysthem> ()._lvl7 = true;
				_savingSysthem.GetComponent<savingSysthem> ().Save ();
			}

			if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level7") {
				_savingSysthem.GetComponent<savingSysthem> ()._lvl8 = true;
				_savingSysthem.GetComponent<savingSysthem> ().Save ();
			}

			if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level8") {
				//_savingSysthem.GetComponent<savingSysthem> ()._lvl9 = true;
				_savingSysthem.GetComponent<savingSysthem> ().Save ();
			}
			Application.LoadLevel ("Win");
		}
	}
}
