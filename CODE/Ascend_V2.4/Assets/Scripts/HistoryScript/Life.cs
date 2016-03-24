using UnityEngine;
using System.Collections;

//Ce script correspond a la vie du player

public class Life : MonoBehaviour
{
	GUIStyle smallFont;
	public Font myFont;
	public int life;
	
	public GameObject _savingSysthem;
	
	void Start ()
	{
		_savingSysthem = GameObject.Find ("SavingSysthem");
		smallFont = new GUIStyle ();
		smallFont.fontSize = 20;
	}
	//=====================================================================================
	// Update is called once per frame
	void Update ()
	{
		if (life <= 0) {
			print ("game over");
			Application.LoadLevel (Application.loadedLevelName);
			_savingSysthem.GetComponent<savingSysthem> ()._actualLevelCoin = 0;
		}
	}
	//=====================================================================================

	void OnTriggerEnter (Collider col)
	{
		if (col.name == "Spear" || col.name == "Projectile(Clone)") {
			life --;
		}
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.name == "Ennemy turret like" || collision.gameObject.name == "Ennemy moving") {
			life --;
		}
	}

	void OnGUI ()
	{
		smallFont.normal.textColor = Color.white;
		smallFont.font = myFont;
		GUI.Label (new Rect (54, 8, 400, 100), "" + gameObject.GetComponent<SoMuchCoins> ().totalScoring, smallFont);
		GUI.Label (new Rect (54, 50, 200, 100), "" + life, smallFont);
		//GUI.color = Color.white;
	}
}
