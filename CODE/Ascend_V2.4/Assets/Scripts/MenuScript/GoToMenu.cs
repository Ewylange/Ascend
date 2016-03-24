using UnityEngine;
using System.Collections;

public class GoToMenu : MonoBehaviour
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

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.name == "MyLineToBounce") {
			_savingSysthem.GetComponent<savingSysthem> ().Load ();
			_savingSysthem.GetComponent<savingSysthem> ()._lvl1 = true;
			StartCoroutine (MyMethod ());
		}
	}

	IEnumerator MyMethod ()
	{
		yield return new WaitForSeconds (0.5f);
		Application.LoadLevel ("ModeSelection");
	}
}
