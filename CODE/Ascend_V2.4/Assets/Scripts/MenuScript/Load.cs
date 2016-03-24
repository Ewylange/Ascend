using UnityEngine;
using System.Collections;

public class Load : MonoBehaviour {

	SpriteRenderer ImageChargement;

	// Use this for initialization
	void Start () {

		ImageChargement.enabled = false;
	}
	
	// Update is called once per frame

		public void LoadScene(int level)
		{

		Application.LoadLevelAsync(level);
		ImageChargement.enabled = true;

		}
	

}
