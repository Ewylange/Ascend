using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//THINGS TO TP HAS: FOND + LIMITES + MAIN CAMERA

public class Portals : MonoBehaviour 
{
	public GameObject pointNext;
	public List<GameObject> thingsToTp = new List<GameObject>();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.name == "Player")
		{
			StartCoroutine(PortalDesactive());
			foreach(GameObject _objets in thingsToTp)
			{
				col.transform.position = pointNext.gameObject.transform.position;
				//_objets.transform.position = Vector3.Lerp(_objets.transform.position,(_objets.transform.position.x, pointB.gameObject.transform.position.y, _objets.transform.position.z), 10f * Time.deltaTime);
				_objets.transform.position = new Vector3 (_objets.transform.position.x, pointNext.gameObject.transform.position.y, _objets.transform.position.z);
			}
		}
	}

	IEnumerator PortalDesactive() 
	{
		pointNext.GetComponent<BoxCollider>().enabled = false;
		yield return new WaitForSeconds(0.5f);
		pointNext.GetComponent<BoxCollider>().enabled = true;
	}
}
