using UnityEngine;
using System.Collections;

public class Spears : MonoBehaviour 
{
	public float _timeArmement = 2f;
	public float _spearVelocity = 5f;
	public string _sensDeDirection;
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.name == "Player")
		{
			StartCoroutine(Armement());
		}
	}

	IEnumerator Armement() 
	{
		yield return new WaitForSeconds(_timeArmement);

		foreach(Rigidbody r in GetComponentsInChildren<Rigidbody>())
		{
			if(r.name == "Spear" && _sensDeDirection == "gauche")
			{
				r.velocity = transform.TransformDirection(Vector3.left * _spearVelocity);
			}
			if(r.name == "Spear" && _sensDeDirection == "droite")
			{
				r.velocity = transform.TransformDirection(Vector3.right * _spearVelocity);
			}
		}
	}
}
