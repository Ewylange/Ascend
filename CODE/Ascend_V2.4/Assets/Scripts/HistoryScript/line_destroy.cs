using UnityEngine;
using System.Collections;

public class line_destroy : MonoBehaviour 
{
	//=====================================================================================
	void OnCollisionExit(Collision collisionInfo)
	{
		//ici on ne detruit pas vraiment l'objet on desactive le mesh et le collider mais le gameobject continue sur la scene.
		StartCoroutine(MyMethod());
	}
	//=====================================================================================

	//=====================================================================================
	IEnumerator MyMethod()
	{
		//je suis obligee d'attendre un peu parceque sinon la balle ne repart pas vers le haut et traverse le carre
		yield return new WaitForSeconds(0.1f);
		GetComponent<BoxCollider>().enabled=false;
		GetComponent<MeshRenderer>().enabled=false;
	}
	//=====================================================================================
}
