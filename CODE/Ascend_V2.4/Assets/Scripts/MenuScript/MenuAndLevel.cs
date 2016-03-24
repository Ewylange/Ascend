using UnityEngine;
using System.Collections;

public class MenuAndLevel : MonoBehaviour
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

	public void GoToModeSelection ()
	{
		Application.LoadLevel ("ModeSelection");
	}

	public void GoToLevelSelection ()
	{
		Application.LoadLevel ("LevelSelection");
	}

	public void GoToShop ()
	{
		Application.LoadLevel ("Shop");
	}

	public void LoadNextLevel ()
	{
		if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level1") {
			Application.LoadLevel ("level2");
		}
		
		if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level2") {
			Application.LoadLevel ("level3");
		}
		
		if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level3") {
			Application.LoadLevel ("level4");
		}
		
		if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level4") {
			Application.LoadLevel ("level5");
		}
		
		if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level5") {
			Application.LoadLevel ("level6");
		}
		
		if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level6") {
			Application.LoadLevel ("level7");
		}
		
		if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level7") {
			Application.LoadLevel ("level8");
		}
		
		if (_savingSysthem.GetComponent<savingSysthem> ()._actualLevelName == "level8") {
			//Application.LoadLevel ("level9");
		}
	}


	public void PlayLevel1 ()
	{
		Application.LoadLevel ("level1");
	}

	public void PlayLevel2 ()
	{
		Application.LoadLevel ("level2");
	}

	public void PlayLevel3 ()
	{
		Application.LoadLevel ("level3");
	}

	public void PlayLevel4 ()
	{
		Application.LoadLevel ("level4");
	}

	public void PlayLevel5 ()
	{
		Application.LoadLevel ("level5");
	}

	public void PlayLevel6 ()
	{
		Application.LoadLevel ("level6");
	}

	public void PlayLevel7 ()
	{
		Application.LoadLevel ("level7");
	}

	public void PlayLevel8 ()
	{
		Application.LoadLevel ("level8");
	}

	public void PlayLevel9 ()
	{
		Application.LoadLevel ("level9");
	}
}
