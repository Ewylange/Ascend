using UnityEngine;
using System.Collections;

//Ce script doit se mettre dans le gazblock
public class gazBlock : MonoBehaviour 
{
	//Temps que le gaz reste sur l'ecran
	public int _timeTillEndOfGazEffect = 5;

	//================================================================================================================================
	void OnTriggerEnter(Collider collision)
	{
		//Si il y a une collision avec le joueur le gaz s'active
		if(collision.name == "Player")
		{
			this.transform.localScale = new Vector3(4,4,4);
			StartCoroutine(MyMethod());
		}
	}
	//================================================================================================================================


	//================================================================================================================================
	IEnumerator MyMethod() 
	{
		//Apres un certain temps le gamObject est detruit
		yield return new WaitForSeconds(_timeTillEndOfGazEffect);
		Destroy (this.gameObject);
	}
	//================================================================================================================================
}
